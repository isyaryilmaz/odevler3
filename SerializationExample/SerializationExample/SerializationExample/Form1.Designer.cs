namespace SerializationExample
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnYukle;
        private ListBox lstUrunler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnYukle = new Button();
            lstUrunler = new ListBox();
            SuspendLayout();
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(285, 394);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(169, 63);
            btnYukle.TabIndex = 0;
            btnYukle.Text = "Ürünleri Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // lstUrunler
            // 
            lstUrunler.FormattingEnabled = true;
            lstUrunler.Location = new Point(180, 74);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(418, 244);
            lstUrunler.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(803, 610);
            Controls.Add(btnYukle);
            Controls.Add(lstUrunler);
            Name = "Form1";
            Text = "JSON Ürün Listeleyici";
            Load += Form1_Load;
            ResumeLayout(false);
        }
    }
}