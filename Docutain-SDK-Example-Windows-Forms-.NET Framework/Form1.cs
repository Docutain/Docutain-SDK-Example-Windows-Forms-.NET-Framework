using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Docutain_SDK_Example_Windows_Forms_.NET_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            EnableButtons(false);

            //set log level according to your needs
            Docutain.SDK.Windows.Logger.SetLogLevel(Docutain.SDK.Windows.Logger.Level.Debug);

            //initialize the Docutain SDK with your license key
            if (!Docutain.SDK.Windows.DocutainSDK.InitSDK("<YOUR-LICENSE-KEY>", Path.GetTempPath()))
            {
                WriteState("SDK initialization failed");
                btLoadDocument.Enabled = false;
                MessageBox.Show(Docutain.SDK.Windows.DocutainSDK.GetLastError());
            }
 			WriteState("SDK initialized");
        }

        private void EnableButtons(bool Enable)
        {
            btCreatePDF.Enabled = Enable;
            btDocumentData.Enabled = Enable;
            btShowText.Enabled = Enable;
            btAddPage.Enabled = Enable;
        }

        private void WriteState(string Message)
        {
            lbState.Text = Message;
        }

        private async void btLoadDocument_Click(object sender, EventArgs e)
        {
            //open file dialog to pick a file
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Supported files (*.PDF;*.JPG; *.JPEG; *.PNG; *.TIF; *.TIFF; *.HEIC)|*.PDF; *.JPG; *.JPEG; *.PNG; *.TIF; *.TIFF; *.HEIC";
                ofd.Filter += "|PDF files (*.PDF)|*.PDF|JPG files (*.JPG; *.JPEG)|*.JPG; *.JPEG|PNG files (*.PNG)|*.PNG|TIF files (*.TIF; *.TIFF)|*.TIF; *.TIFF|HEIC files (*.HEIC)|*.HEIC";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.Length == 0)
                        return;

                    UseWaitCursor = true;

                    tbOutput.Text = "";

                    bool rc = false;

                    if (rbLDFilepath.Checked)
                    {
                        //load a document from selected file path
                        if(rc = await Docutain.SDK.Windows.Document.Load(ofd.FileName))
                            WriteState("Document loaded (mode filepath)");
                    }
                    if (rbLDBinary.Checked)
                    {
                        //load a document from a byte array
                        byte[] data = File.ReadAllBytes(ofd.FileName);

                        if(rc = await Docutain.SDK.Windows.Document.Load(data, Path.GetExtension(ofd.FileName)))
                            WriteState("Document loaded (mode binary)");
                    }
                    if (rbLDStream.Checked)
                    {
                        //load a document from a stream
                        using (Stream stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            if (rc = await Docutain.SDK.Windows.Document.Load(stream, Path.GetExtension(ofd.FileName)))
                                WriteState("Document loaded (mode stream)");
                        }
                    }

                    UseWaitCursor = false;

                    if (!rc)
                    {
                        EnableButtons(false);
                        WriteState("Loading document failed");
                        MessageBox.Show(Docutain.SDK.Windows.DocutainSDK.GetLastError());
                        return;
                    }

                    EnableButtons(true);
                    lbPageCount.Text = Docutain.SDK.Windows.Document.PageCount().ToString();
                }
            }
        }

        private void btDocumentData_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;

            //analyze the currently loaded document and return detected data as JSON string
            string JSON = Docutain.SDK.Windows.Document.Analyze();
            if(!string.IsNullOrEmpty(JSON))
            {
                //deserialize JSON string into an object of type DocumentData
                DocumentData documentData = JsonConvert.DeserializeObject<DocumentData>(JSON);
                tbOutput.Text = JSON.Replace("\n", Environment.NewLine);
            }
            else
            {
                tbOutput.Text = "No data read";
            }

            WriteState("Document data loaded");
            UseWaitCursor = false;
        }

        private void btShowText_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;

            //get the detected text of the currently loaded document
            //pass -1 for entire document, else page number
            tbOutput.Text = Docutain.SDK.Windows.Document.Text(-1);
 			WriteState("Text loaded");

            UseWaitCursor = false;
        }

        private void btCreatePDF_Click(object sender, EventArgs e)
        {
            //select path where to save the PDF
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.PDF)|*.PDF";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName.Length == 0)
                        return;

                    UseWaitCursor = true;

                    //generate PDF from currently loaded document and save it to the selected path
                    Docutain.SDK.Windows.Document.WritePDF(sfd.FileName, true, Docutain.SDK.Windows.Document.PDFPageFormat.FitToPages);
					WriteState("PDF created");

                    UseWaitCursor = false;
                }
            }
        }

        private async void btAddPage_Click(object sender, EventArgs e)
        {
            //select the file you wish to add as page to the currently loaded document
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Supported files (*.PDF;*.JPG; *.JPEG; *.PNG; *.TIF; *.TIFF; *.HEIC)|*.PDF; *.JPG; *.JPEG; *.PNG; *.TIF; *.TIFF; *.HEIC";
                ofd.Filter += "|PDF files (*.PDF)|*.PDF|JPG files (*.JPG; *.JPEG)|*.JPG; *.JPEG|PNG files (*.PNG)|*.PNG|TIF files (*.TIF; *.TIFF)|*.TIF; *.TIFF|HEIC files (*.HEIC)|*.HEIC";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.Length == 0)
                        return;

                    UseWaitCursor = true;

                    tbOutput.Text = "";

                    bool rc = false;

                    if (rbAPFilepath.Checked)
                    {
                        //add a page to the currently loaded document by using path to the file
                        if (rc = await Docutain.SDK.Windows.Document.AddPage(ofd.FileName))
                            WriteState("Page added (mode filepath)");
                    }
                    if (rbAPBinary.Checked)
                    {
                        //add a page to the currently loaded document by using byte array
                        byte[] data = File.ReadAllBytes(ofd.FileName);

                        if(rc = await Docutain.SDK.Windows.Document.AddPage(data, Path.GetExtension(ofd.FileName)))
                            WriteState("Page added (mode binary)");
                    }
                    if (rbAPStream.Checked)
                    {
                        //add a page to the currently loaded document by using a stream
                        using (Stream stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            if(rc = await Docutain.SDK.Windows.Document.AddPage(stream, Path.GetExtension(ofd.FileName)))
                                WriteState("Page added (mode stream)");
                        }
                    }

                    UseWaitCursor = false;

                    if (!rc)
                    {
                        WriteState("Adding the page failed");
                        MessageBox.Show(Docutain.SDK.Windows.DocutainSDK.GetLastError());
                        return;
                    }

                    lbPageCount.Text = Docutain.SDK.Windows.Document.PageCount().ToString();
                }
            }
        }

        private void btLogfile_Click(object sender, EventArgs e)
        {
            //open the Docutain SDK log file
            Process.Start(Docutain.SDK.Windows.Logger.Filename);
			WriteState("Logfile opened");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DocumentData
    {
        public Address Address { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string InvoiceId { get; set; }
        public string reference { get; set; }
    }

    public class Address
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string CustomerId { get; set; }
        public string IBAN { get; set; }
    }
}
