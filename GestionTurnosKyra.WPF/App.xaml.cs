using System.Configuration;
using System.Data;
using System.Windows;

namespace GestionTurnosKyra.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Window ventana = new Window();
        ventana.Show();
        base.OnStartup(e);
    }
}

