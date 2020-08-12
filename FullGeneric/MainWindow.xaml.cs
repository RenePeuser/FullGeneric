using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FullGeneric.Data.Models;
using FullGeneric.Factory;
using FullGeneric.GenericTypes;
using FullGeneric.Repository;
using FullGeneric.ViewModels;

namespace FullGeneric
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //Variante 1. Repository in Verbindung mit Type direkt Zugriff
            FullGenericFactory<Repository<Tool>>.Instance.GenericType().Add(new Tool("test"));
            FullGenericFactory<Repository<Tool>>.Instance.GenericType().Add(new Tool("test"));         

            ////Variante 2. DatenType in Vebrindung mit allen dazugehörigen Zugriffsbereichen
            ////inkl. Zugriff direkt auf Settings
            //FullGenericFactory<DataType<Tool>>.Instance.GenericType().Data.Add(new Tool());
            //FullGenericFactory<DataType<Tool>>.Instance.GenericType().Settings.Add(new Tool());

            ////Hinzufügen eines neuen processes.
            //FullGenericFactory<ProcessType<Process>>.Instance.GenericType().ProcessData.Add(new Process());

            ////Diese Factory kann auch eizelne Datentypen instanziieren
            //FullGenericFactory<Process>.Instance.GenericType().Name = "Test";          
        }
    }
}
