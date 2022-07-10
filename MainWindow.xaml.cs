using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using For_RKS.ViewModel;
using System.Xml;
using For_RKS.Model;

namespace For_RKS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();


            
            var doc = new XmlDocument();
            doc.Load("Commands.xml");
            var element = doc.DocumentElement;
            PrintItem(element);     
            
        }

        private static void PrintItem(XmlElement element)
        {
            foreach (XmlNode xnode in element)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    XmlNode attr2 = xnode.Attributes.GetNamedItem("code");
                    if (attr != null & attr2 != null)
                    {
                        //MessageBox.Show(attr.Value + "   " + attr2.Value);
                    }
                }
            }

        }
    }
}
