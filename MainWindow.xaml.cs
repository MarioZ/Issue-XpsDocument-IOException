using System.IO;
using System.Windows;
using System.Windows.Xps.Packaging;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private XpsDocument xps;

        public MainWindow()
        {
            InitializeComponent();

            /********************************************************************/
            /* XPS document with picture and ReadWrite access reproduces issue. */
            /********************************************************************/
            this.xps = new XpsDocument("input.xps", FileAccess.ReadWrite);
            this.viewer.Document = this.xps.GetFixedDocumentSequence();

            /**********************************************************************/
            /* XPS document with picture and Read access doesn't reproduce issue. */
            /**********************************************************************/
            //this.xps = new XpsDocument("input.xps", FileAccess.Read);
            //this.viewer.Document = this.xps.GetFixedDocumentSequence();

            /*********************************************************/
            /* XPS document without picture doesn't reproduce issue. */
            /*********************************************************/
            //this.xps = new XpsDocument("inputWithoutPicture.xps", FileAccess.ReadWrite);
            //this.viewer.Document = this.xps.GetFixedDocumentSequence();

        }
    }
}
