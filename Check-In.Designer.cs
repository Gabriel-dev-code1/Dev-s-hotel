
namespace PIM_Hotel
{
    partial class Check_In
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
            this.btnCheckIN = new System.Windows.Forms.Button();
            this.cadreservaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservaDataSet3 = new PIM_Hotel.reservaDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.reservaDataSet2 = new PIM_Hotel.reservaDataSet2();
            this.cadreservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_reservaTableAdapter = new PIM_Hotel.reservaDataSet2TableAdapters.cad_reservaTableAdapter();
            this.cad_reservaTableAdapter1 = new PIM_Hotel.reservaDataSet3TableAdapters.cad_reservaTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tipoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckIN
            // 
            this.btnCheckIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckIN.Location = new System.Drawing.Point(412, 367);
            this.btnCheckIN.Name = "btnCheckIN";
            this.btnCheckIN.Size = new System.Drawing.Size(96, 36);
            this.btnCheckIN.TabIndex = 68;
            this.btnCheckIN.Text = "Check In";
            this.btnCheckIN.UseVisualStyleBackColor = true;
            this.btnCheckIN.Click += new System.EventHandler(this.btnCheckIN_Click);
            // 
            // cadreservaBindingSource1
            // 
            this.cadreservaBindingSource1.DataMember = "cad_reserva";
            this.cadreservaBindingSource1.DataSource = this.reservaDataSet3;
            // 
            // reservaDataSet3
            // 
            this.reservaDataSet3.DataSetName = "reservaDataSet3";
            this.reservaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Realizar check-in do hóspede";
            // 
            // reservaDataSet2
            // 
            this.reservaDataSet2.DataSetName = "reservaDataSet2";
            this.reservaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadreservaBindingSource
            // 
            this.cadreservaBindingSource.DataMember = "cad_reserva";
            this.cadreservaBindingSource.DataSource = this.reservaDataSet2;
            // 
            // cad_reservaTableAdapter
            // 
            this.cad_reservaTableAdapter.ClearBeforeFill = true;
            // 
            // cad_reservaTableAdapter1
            // 
            this.cad_reservaTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 17);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = ".";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tipoquartoDataGridViewTextBoxColumn
            // 
            this.tipoquartoDataGridViewTextBoxColumn.DataPropertyName = "tipo_quarto";
            this.tipoquartoDataGridViewTextBoxColumn.HeaderText = "tipo_quarto";
            this.tipoquartoDataGridViewTextBoxColumn.Name = "tipoquartoDataGridViewTextBoxColumn";
            // 
            // numeroquartoDataGridViewTextBoxColumn
            // 
            this.numeroquartoDataGridViewTextBoxColumn.DataPropertyName = "numero_quarto";
            this.numeroquartoDataGridViewTextBoxColumn.HeaderText = "numero_quarto";
            this.numeroquartoDataGridViewTextBoxColumn.Name = "numeroquartoDataGridViewTextBoxColumn";
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn,
            this.numeroquartoDataGridViewTextBoxColumn,
            this.tipoquartoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadreservaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(77, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 300);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(77, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(29, 17);
            this.checkBox2.TabIndex = 73;
            this.checkBox2.Text = ".";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(77, 113);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(29, 17);
            this.checkBox3.TabIndex = 74;
            this.checkBox3.Text = ".";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(77, 136);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(29, 17);
            this.checkBox4.TabIndex = 75;
            this.checkBox4.Text = ".";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(77, 159);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(29, 17);
            this.checkBox5.TabIndex = 76;
            this.checkBox5.Text = ".";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(77, 182);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(29, 17);
            this.checkBox6.TabIndex = 77;
            this.checkBox6.Text = ".";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(77, 205);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(29, 17);
            this.checkBox7.TabIndex = 78;
            this.checkBox7.Text = ".";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(77, 228);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(29, 17);
            this.checkBox8.TabIndex = 79;
            this.checkBox8.Text = ".";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(77, 251);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(29, 17);
            this.checkBox9.TabIndex = 80;
            this.checkBox9.Text = ".";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(77, 274);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(29, 17);
            this.checkBox10.TabIndex = 81;
            this.checkBox10.Text = ".";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(77, 297);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(29, 17);
            this.checkBox11.TabIndex = 82;
            this.checkBox11.Text = ".";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(77, 320);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(29, 17);
            this.checkBox12.TabIndex = 83;
            this.checkBox12.Text = ".";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 413);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCheckIN);
            this.Name = "Check_In";
            this.Text = "Check_In";
            this.Load += new System.EventHandler(this.Check_In_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckIN;
        private System.Windows.Forms.Label label1;
        private reservaDataSet2 reservaDataSet2;
        private System.Windows.Forms.BindingSource cadreservaBindingSource;
        private reservaDataSet2TableAdapters.cad_reservaTableAdapter cad_reservaTableAdapter;
        private reservaDataSet3 reservaDataSet3;
        private System.Windows.Forms.BindingSource cadreservaBindingSource1;
        private reservaDataSet3TableAdapters.cad_reservaTableAdapter cad_reservaTableAdapter1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
    }
}