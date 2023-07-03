using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Styling;
using Avalonia.VisualTree;
using CefNet;
using CefNet.Avalonia;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AvaloniaApp
{
	public class WebViewTab : TabItem, IStyleable
	{
		private class WebViewTabTitle : TemplatedControl
		{
			private WebViewTab _tab;
			private FormattedText _xButton;
			private IBrush _xbuttonBrush;
			public WebViewTabTitle(WebViewTab tab)
			{
				_tab = tab;
			}

			public string Text
			{
				get
				{
					return FormattedText?.ToString();
				}
				set
				{
					if (string.IsNullOrWhiteSpace(value))
					{
						this.FormattedText = null;
						this.InvalidateMeasure();
						return;
					}
					this.FormattedText = new FormattedText(
						value,
						CultureInfo.CurrentCulture,
						FlowDirection,
						new Typeface(FontFamily, FontStyle, FontWeight),
						FontSize,
						Brushes.Black);
					this.InvalidateMeasure();
				}
			}

			private FormattedText FormattedText { get; set; }

			private FormattedText XButton
			{
				get
				{
					if (_xButton == null)
					{
						_xButton = new FormattedText(
							"x",
							CultureInfo.CurrentCulture,
							FlowDirection,
							new Typeface(FontFamily, FontStyle, FontWeight.Bold),
							FontSize,
							Brushes.Gray);
					}
					return _xButton;
				}
			}

			protected override Size MeasureOverride(Size constraint)
			{
				var ft = this.FormattedText;
				if (ft == null)
					return base.MeasureOverride(constraint);
				return new Size(ft.Width + XButton.Width + 4, ft.Height);
			}

			protected override void OnPointerReleased(PointerReleasedEventArgs e)
			{
				if (e.InitialPressMouseButton == MouseButton.Left)
				{
					if (GetXButtonRect().Contains(e.GetPosition(this)))
					{
						_tab.Close();
					}
				}
				base.OnPointerReleased(e);
			}

			private Rect GetXButtonRect()
			{
				return new Rect(Bounds.Width - XButton.Width, 0, XButton.Width, XButton.Height);
			}

			protected override void OnPointerMoved(PointerEventArgs e)
			{
				SetXButtonBrush(GetXButtonRect().Contains(e.GetPosition(this)) ? Brushes.Black : Brushes.Gray);
				base.OnPointerMoved(e);
			}

			protected override void OnPointerExited(PointerEventArgs e)
			{
				SetXButtonBrush(Brushes.Gray);
				base.OnPointerExited(e);
			}

			private void SetXButtonBrush(ISolidColorBrush brush)
			{
				if (brush != _xbuttonBrush)
				{
					_xbuttonBrush = brush;
					XButton.SetForegroundBrush(brush);
					this.InvalidateVisual();
				}
			}

			public override void Render(DrawingContext drawingContext)
			{
				FormattedText formattedText = this.FormattedText;
				if (formattedText == null)
					return;

				drawingContext.DrawText(formattedText, new Point());
				drawingContext.DrawText(XButton, new Point(Bounds.Width - XButton.Width, 0));
			}
		}


		public WebViewTab()
			: this(new CustomWebView())
		{

		}

		//public WebViewTab(CefBrowserSettings settings, CefRequestContext requestContext)
		//	: this(new WebView(settings, requestContext))
		//{

		//}

		private WebViewTab(WebView webview)
		{
			webview.CreateWindow += Webview_CreateWindow;
			webview.DocumentTitleChanged += HandleDocumentTitleChanged;
			this.WebView = webview;
			this.Header = new WebViewTabTitle(this);
		}

		Type IStyleable.StyleKey
		{
			get { return typeof(TabItem); }
		}

		public string Title
		{
			get
			{
				return ((WebViewTabTitle)this.Header).Text;
			}
			set
			{
				((WebViewTabTitle)this.Header).Text = value;
			}
		}

		protected override void OnInitialized()
		{
			base.OnInitialized();
			this.Content = this.WebView;
		}

		public void Close()
		{
			this.WebView.Close();

			var tabs = this.Parent as TabControl;
			if (tabs == null)
				return;
			((AvaloniaList<object>)tabs.ItemsSource).Remove(this);
		}

		private void HandleDocumentTitleChanged(object sender, DocumentTitleChangedEventArgs e)
		{
			this.Title = e.Title;
			//this.ToolTipText = e.Title;
		}

		public IChromiumWebView WebView { get; protected set; }

		public bool PopupHandlingDisabled { get; set; }

		private void Webview_CreateWindow(object sender, CreateWindowEventArgs e)
		{
			if (PopupHandlingDisabled)
				return;

			TabControl tabs = this.FindTabControl();
			if (tabs == null)
			{
				e.Cancel = true;
				return;
			}

			var avaloniaWindow = this.GetVisualRoot() as Window;
			if (avaloniaWindow == null)
				throw new InvalidOperationException("Window not found!");

			var webview = new CustomWebView((WebView)this.WebView);

			IPlatformHandle platformHandle = avaloniaWindow.TryGetPlatformHandle();
			if (platformHandle is IMacOSTopLevelPlatformHandle macOSHandle)
				e.WindowInfo.SetAsWindowless(macOSHandle.GetNSWindowRetained());
			else
				e.WindowInfo.SetAsWindowless(platformHandle.Handle);

			e.Client = webview.Client;
			OnCreateWindow(webview);
		}


		protected void OnCreateWindow(WebView webview)
		{
			var tab = new WebViewTab(webview);
			TabControl tabs = this.FindTabControl();
			((AvaloniaList<object>)tabs.ItemsSource).Add(tab);
			tabs.SelectedItem = tab;
		}
	}
}
