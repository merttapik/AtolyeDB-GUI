
namespace Atolye
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atolyeDBDataSet7 = new Atolye.AtolyeDBDataSet7();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ayakkabiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atolyeDBDataSet8 = new Atolye.AtolyeDBDataSet8();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.musteriTableAdapter = new Atolye.AtolyeDBDataSet7TableAdapters.MusteriTableAdapter();
            this.ayakkabiTableAdapter = new Atolye.AtolyeDBDataSet8TableAdapters.AyakkabiTableAdapter();
            this.atolyeDBDataSet9 = new Atolye.AtolyeDBDataSet9();
            this.musteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter1 = new Atolye.AtolyeDBDataSet9TableAdapters.MusteriTableAdapter();
            this.musteriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.atolyeDBDataSet10 = new Atolye.AtolyeDBDataSet10();
            this.musteriTableAdapter2 = new Atolye.AtolyeDBDataSet10TableAdapters.MusteriTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayakkabiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.musteriBindingSource, "musteri_id", true));
            this.comboBox1.DataSource = this.musteriBindingSource;
            this.comboBox1.DisplayMember = "musteri_isim";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "musteri_id";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.atolyeDBDataSet7;
            // 
            // atolyeDBDataSet7
            // 
            this.atolyeDBDataSet7.DataSetName = "AtolyeDBDataSet7";
            this.atolyeDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.ayakkabiBindingSource;
            this.comboBox2.DisplayMember = "ayakkabi_id";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "ayakkabi_id";
            // 
            // ayakkabiBindingSource
            // 
            this.ayakkabiBindingSource.DataMember = "Ayakkabi";
            this.ayakkabiBindingSource.DataSource = this.atolyeDBDataSet8;
            // 
            // atolyeDBDataSet8
            // 
            this.atolyeDBDataSet8.DataSetName = "AtolyeDBDataSet8";
            this.atolyeDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(94, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 26);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(16, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(113, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // ayakkabiTableAdapter
            // 
            this.ayakkabiTableAdapter.ClearBeforeFill = true;
            // 
            // atolyeDBDataSet9
            // 
            this.atolyeDBDataSet9.DataSetName = "AtolyeDBDataSet9";
            this.atolyeDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource1
            // 
            this.musteriBindingSource1.DataMember = "Musteri";
            this.musteriBindingSource1.DataSource = this.atolyeDBDataSet9;
            // 
            // musteriTableAdapter1
            // 
            this.musteriTableAdapter1.ClearBeforeFill = true;
            // 
            // musteriBindingSource2
            // 
            this.musteriBindingSource2.DataMember = "Musteri";
            this.musteriBindingSource2.DataSource = this.atolyeDBDataSet10;
            // 
            // atolyeDBDataSet10
            // 
            this.atolyeDBDataSet10.DataSetName = "AtolyeDBDataSet10";
            this.atolyeDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter2
            // 
            this.musteriTableAdapter2.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müşteri Soyad :";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.musteriBindingSource2, "musteri_id", true));
            this.comboBox3.DataSource = this.musteriBindingSource2;
            this.comboBox3.DisplayMember = "musteri_soyisim";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(155, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "musteri_id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sipariş Oluştur";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Yeni Sipariş";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayakkabiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AtolyeDBDataSet7 atolyeDBDataSet7;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private AtolyeDBDataSet7TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private AtolyeDBDataSet8 atolyeDBDataSet8;
        private System.Windows.Forms.BindingSource ayakkabiBindingSource;
        private AtolyeDBDataSet8TableAdapters.AyakkabiTableAdapter ayakkabiTableAdapter;
        private AtolyeDBDataSet9 atolyeDBDataSet9;
        private System.Windows.Forms.BindingSource musteriBindingSource1;
        private AtolyeDBDataSet9TableAdapters.MusteriTableAdapter musteriTableAdapter1;
        private AtolyeDBDataSet10 atolyeDBDataSet10;
        private System.Windows.Forms.BindingSource musteriBindingSource2;
        private AtolyeDBDataSet10TableAdapters.MusteriTableAdapter musteriTableAdapter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
    }
}