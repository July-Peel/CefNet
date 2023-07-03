using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AvaloniaApp
{
	public partial class MessageBox : Window
	{
		public MessageBox()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public static async Task Show(string text)
		{
			var lifetime = Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
			if (lifetime is null)
				return;
			Window mainWindow = lifetime.MainWindow;
			if (mainWindow is null)
				return;
			var window = new MessageBox();
			window.Content = text;
			await window.ShowDialog(mainWindow);
		}
	}
}
