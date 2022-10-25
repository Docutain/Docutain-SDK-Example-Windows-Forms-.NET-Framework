
namespace Docutain_SDK_Example_Windows_Forms_.NET_Framework
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLoadDocument = new System.Windows.Forms.Button();
            this.btShowText = new System.Windows.Forms.Button();
            this.btDocumentData = new System.Windows.Forms.Button();
            this.btCreatePDF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAPFilepath = new System.Windows.Forms.RadioButton();
            this.rbAPStream = new System.Windows.Forms.RadioButton();
            this.rbAPBinary = new System.Windows.Forms.RadioButton();
            this.btAddPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLDFilepath = new System.Windows.Forms.RadioButton();
            this.rbLDStream = new System.Windows.Forms.RadioButton();
            this.rbLDBinary = new System.Windows.Forms.RadioButton();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPageCount = new System.Windows.Forms.Label();
            this.btLogfile = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoadDocument
            // 
            this.btLoadDocument.Location = new System.Drawing.Point(6, 19);
            this.btLoadDocument.Name = "btLoadDocument";
            this.btLoadDocument.Size = new System.Drawing.Size(139, 23);
            this.btLoadDocument.TabIndex = 0;
            this.btLoadDocument.Text = "Load document";
            this.btLoadDocument.UseVisualStyleBackColor = true;
            this.btLoadDocument.Click += new System.EventHandler(this.btLoadDocument_Click);
            // 
            // btShowText
            // 
            this.btShowText.Location = new System.Drawing.Point(296, 51);
            this.btShowText.Name = "btShowText";
            this.btShowText.Size = new System.Drawing.Size(139, 23);
            this.btShowText.TabIndex = 1;
            this.btShowText.Text = "Show text";
            this.btShowText.UseVisualStyleBackColor = true;
            this.btShowText.Click += new System.EventHandler(this.btShowText_Click);
            // 
            // btDocumentData
            // 
            this.btDocumentData.Location = new System.Drawing.Point(296, 19);
            this.btDocumentData.Name = "btDocumentData";
            this.btDocumentData.Size = new System.Drawing.Size(139, 23);
            this.btDocumentData.TabIndex = 2;
            this.btDocumentData.Text = "Document data";
            this.btDocumentData.UseVisualStyleBackColor = true;
            this.btDocumentData.Click += new System.EventHandler(this.btDocumentData_Click);
            // 
            // btCreatePDF
            // 
            this.btCreatePDF.Location = new System.Drawing.Point(296, 80);
            this.btCreatePDF.Name = "btCreatePDF";
            this.btCreatePDF.Size = new System.Drawing.Size(139, 23);
            this.btCreatePDF.TabIndex = 3;
            this.btCreatePDF.Text = "Create PDF";
            this.btCreatePDF.UseVisualStyleBackColor = true;
            this.btCreatePDF.Click += new System.EventHandler(this.btCreatePDF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btAddPage);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btLoadDocument);
            this.groupBox1.Controls.Add(this.btShowText);
            this.groupBox1.Controls.Add(this.btCreatePDF);
            this.groupBox1.Controls.Add(this.btDocumentData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbAPFilepath);
            this.panel2.Controls.Add(this.rbAPStream);
            this.panel2.Controls.Add(this.rbAPBinary);
            this.panel2.Location = new System.Drawing.Point(151, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 73);
            this.panel2.TabIndex = 5;
            // 
            // rbAPFilepath
            // 
            this.rbAPFilepath.AutoSize = true;
            this.rbAPFilepath.Checked = true;
            this.rbAPFilepath.Location = new System.Drawing.Point(3, 3);
            this.rbAPFilepath.Name = "rbAPFilepath";
            this.rbAPFilepath.Size = new System.Drawing.Size(62, 17);
            this.rbAPFilepath.TabIndex = 2;
            this.rbAPFilepath.TabStop = true;
            this.rbAPFilepath.Text = "Filepath";
            this.rbAPFilepath.UseVisualStyleBackColor = true;
            // 
            // rbAPStream
            // 
            this.rbAPStream.AutoSize = true;
            this.rbAPStream.Location = new System.Drawing.Point(3, 49);
            this.rbAPStream.Name = "rbAPStream";
            this.rbAPStream.Size = new System.Drawing.Size(58, 17);
            this.rbAPStream.TabIndex = 1;
            this.rbAPStream.Text = "Stream";
            this.rbAPStream.UseVisualStyleBackColor = true;
            // 
            // rbAPBinary
            // 
            this.rbAPBinary.AutoSize = true;
            this.rbAPBinary.Location = new System.Drawing.Point(3, 26);
            this.rbAPBinary.Name = "rbAPBinary";
            this.rbAPBinary.Size = new System.Drawing.Size(54, 17);
            this.rbAPBinary.TabIndex = 0;
            this.rbAPBinary.Text = "Binary";
            this.rbAPBinary.UseVisualStyleBackColor = true;
            // 
            // btAddPage
            // 
            this.btAddPage.Location = new System.Drawing.Point(151, 19);
            this.btAddPage.Name = "btAddPage";
            this.btAddPage.Size = new System.Drawing.Size(139, 23);
            this.btAddPage.TabIndex = 5;
            this.btAddPage.Text = "Add page";
            this.btAddPage.UseVisualStyleBackColor = true;
            this.btAddPage.Click += new System.EventHandler(this.btAddPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLDFilepath);
            this.panel1.Controls.Add(this.rbLDStream);
            this.panel1.Controls.Add(this.rbLDBinary);
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 73);
            this.panel1.TabIndex = 4;
            // 
            // rbLDFilepath
            // 
            this.rbLDFilepath.AutoSize = true;
            this.rbLDFilepath.Checked = true;
            this.rbLDFilepath.Location = new System.Drawing.Point(3, 3);
            this.rbLDFilepath.Name = "rbLDFilepath";
            this.rbLDFilepath.Size = new System.Drawing.Size(62, 17);
            this.rbLDFilepath.TabIndex = 2;
            this.rbLDFilepath.TabStop = true;
            this.rbLDFilepath.Text = "Filepath";
            this.rbLDFilepath.UseVisualStyleBackColor = true;
            // 
            // rbLDStream
            // 
            this.rbLDStream.AutoSize = true;
            this.rbLDStream.Location = new System.Drawing.Point(3, 49);
            this.rbLDStream.Name = "rbLDStream";
            this.rbLDStream.Size = new System.Drawing.Size(58, 17);
            this.rbLDStream.TabIndex = 1;
            this.rbLDStream.Text = "Stream";
            this.rbLDStream.UseVisualStyleBackColor = true;
            // 
            // rbLDBinary
            // 
            this.rbLDBinary.AutoSize = true;
            this.rbLDBinary.Location = new System.Drawing.Point(3, 26);
            this.rbLDBinary.Name = "rbLDBinary";
            this.rbLDBinary.Size = new System.Drawing.Size(54, 17);
            this.rbLDBinary.TabIndex = 0;
            this.rbLDBinary.Text = "Binary";
            this.rbLDBinary.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Location = new System.Drawing.Point(12, 227);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(527, 340);
            this.tbOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(400, 582);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(139, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of pages:";
            // 
            // lbPageCount
            // 
            this.lbPageCount.AutoSize = true;
            this.lbPageCount.Location = new System.Drawing.Point(115, 180);
            this.lbPageCount.Name = "lbPageCount";
            this.lbPageCount.Size = new System.Drawing.Size(13, 13);
            this.lbPageCount.TabIndex = 7;
            this.lbPageCount.Text = "0";
            // 
            // btLogfile
            // 
            this.btLogfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogfile.Location = new System.Drawing.Point(255, 582);
            this.btLogfile.Name = "btLogfile";
            this.btLogfile.Size = new System.Drawing.Size(139, 23);
            this.btLogfile.TabIndex = 6;
            this.btLogfile.Text = "Open logfile";
            this.btLogfile.UseVisualStyleBackColor = true;
            this.btLogfile.Click += new System.EventHandler(this.btLogfile_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(115, 155);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(0, 13);
            this.lbState.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "State:";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 617);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLogfile);
            this.Controls.Add(this.lbPageCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(480, 420);
            this.Name = "Form1";
            this.Text = "Docutain-SDK-Example-Windows-Forms-.NET Framework";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoadDocument;
        private System.Windows.Forms.Button btShowText;
        private System.Windows.Forms.Button btDocumentData;
        private System.Windows.Forms.Button btCreatePDF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbLDFilepath;
        private System.Windows.Forms.RadioButton rbLDStream;
        private System.Windows.Forms.RadioButton rbLDBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAPFilepath;
        private System.Windows.Forms.RadioButton rbAPStream;
        private System.Windows.Forms.RadioButton rbAPBinary;
        private System.Windows.Forms.Label lbPageCount;
        private System.Windows.Forms.Button btLogfile;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label label4;
    }
}

