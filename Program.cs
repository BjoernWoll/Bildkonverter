using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


             Converter.Model.ConvertModel mdl = new Model.ConvertModel();
            //Model
           // Converter.Model.MainModel mdl = new Model.MainModel();
            //View
            Converter.View.ConverterView view = new View.ConverterView();
            //Presenter
            Presenter.Presenter Presenter = new Converter.Presenter.Presenter(mdl, view);
            //Presenter.MainPresenter Presenter = new Converter.Presenter.MainPresenter(mdl, view);
            Application.Run(view);
        }
    }
}
