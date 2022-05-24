
namespace Atolye
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mstrbky = new System.Windows.Forms.TextBox();
            this.mstrtel = new System.Windows.Forms.TextBox();
            this.mstradr = new System.Windows.Forms.TextBox();
            this.mstrsad = new System.Windows.Forms.TextBox();
            this.mstad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atolyeDBDataSet1 = new Atolye.AtolyeDBDataSet1();
            this.atolyeDBDataSet = new Atolye.AtolyeDBDataSet();
            this.atolyeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilTableAdapter = new Atolye.AtolyeDBDataSet1TableAdapters.ilTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bakiye :";
            // 
            // mstrbky
            // 
            this.mstrbky.Location = new System.Drawing.Point(115, 267);
            this.mstrbky.Name = "mstrbky";
            this.mstrbky.Size = new System.Drawing.Size(100, 20);
            this.mstrbky.TabIndex = 5;
            // 
            // mstrtel
            // 
            this.mstrtel.Location = new System.Drawing.Point(115, 229);
            this.mstrtel.Name = "mstrtel";
            this.mstrtel.Size = new System.Drawing.Size(100, 20);
            this.mstrtel.TabIndex = 6;
            // 
            // mstradr
            // 
            this.mstradr.Location = new System.Drawing.Point(115, 164);
            this.mstradr.Multiline = true;
            this.mstradr.Name = "mstradr";
            this.mstradr.Size = new System.Drawing.Size(204, 49);
            this.mstradr.TabIndex = 7;
            this.mstradr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mstrsad
            // 
            this.mstrsad.Location = new System.Drawing.Point(115, 92);
            this.mstrsad.Name = "mstrsad";
            this.mstrsad.Size = new System.Drawing.Size(100, 20);
            this.mstrsad.TabIndex = 8;
            // 
            // mstad
            // 
            this.mstad.Location = new System.Drawing.Point(115, 52);
            this.mstad.Name = "mstad";
            this.mstad.Size = new System.Drawing.Size(100, 20);
            this.mstad.TabIndex = 9;
            this.mstad.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(34, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(162, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "İl :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ilBindingSource;
            this.comboBox1.DisplayMember = "il_isim";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "il_id";
            // 
            // ilBindingSource
            // 
            this.ilBindingSource.DataMember = "il";
            this.ilBindingSource.DataSource = this.atolyeDBDataSet1;
            // 
            // atolyeDBDataSet1
            // 
            this.atolyeDBDataSet1.DataSetName = "AtolyeDBDataSet1";
            this.atolyeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atolyeDBDataSet
            // 
            this.atolyeDBDataSet.DataSetName = "AtolyeDBDataSet";
            this.atolyeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atolyeDBDataSetBindingSource
            // 
            this.atolyeDBDataSetBindingSource.DataSource = this.atolyeDBDataSet;
            this.atolyeDBDataSetBindingSource.Position = 0;
            // 
            // ilTableAdapter
            // 
            this.ilTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Müşteri Oluştur";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mstad);
            this.Controls.Add(this.mstrsad);
            this.Controls.Add(this.mstradr);
            this.Controls.Add(this.mstrtel);
            this.Controls.Add(this.mstrbky);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Müşteri Ekleme";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atolyeDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mstrbky;
        private System.Windows.Forms.TextBox mstrtel;
        private System.Windows.Forms.TextBox mstradr;
        private System.Windows.Forms.TextBox mstrsad;
        private System.Windows.Forms.TextBox mstad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private AtolyeDBDataSet atolyeDBDataSet;
        private System.Windows.Forms.BindingSource atolyeDBDataSetBindingSource;
        private AtolyeDBDataSet1 atolyeDBDataSet1;
        private System.Windows.Forms.BindingSource ilBindingSource;
        private AtolyeDBDataSet1TableAdapters.ilTableAdapter ilTableAdapter;
        private System.Windows.Forms.Label label7;
    }
}