using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void EnviarCV(object sender, EventArgs e)
        {
            string nombre = nombre_.Text;
            string apellido = apellido_.Text;
            string email = email_.Text;
            string telefono = numero_.Text;
            string experiencia = experencia_.Text;
            string habilidades = habilidades_.Text;

            string cvHtml =
                $"<!DOCTYPE html>\n" +
                $"<html>\n" +
                $"<head>\n" +
                $"<title>CV - {nombre} {apellido}</title>\n" +
                $"<style>\n" +
                $"body {{ font-family: Arial, sans-serif; text-align: center; margin: 0 auto; width: 80%; }}\n" + 
                $"h1 {{ color: #ABD8FC; }}\n" + 
                $"h2 {{ color: #466782; }}\n" +
                $"p {{ margin-bottom: 10px; }}\n" +
                $"</style>\n" +
                $"</head>\n" +
                $"<body>\n" +
                $"<h1>{nombre} {apellido}</h1>\n" +
                $"<p>Email: {email}</p>\n" +
                $"<p>Teléfono: {telefono}</p>\n" +
                $"<h2>Experiencia</h2>\n" +
                $"<p>{experiencia}</p>\n" +
                $"<h2>Habilidades</h2>\n" +
                $"<p>{habilidades}</p>\n" +
                $"</body>\n" +
                $"</html>";

            WebView webView = new WebView();
            webView.Source = new HtmlWebViewSource { Html = cvHtml };
            Content = webView;

            }
    }
}