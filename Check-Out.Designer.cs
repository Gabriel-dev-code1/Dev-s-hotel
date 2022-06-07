
namespace PIM_Hotel
{
    partial class Check_Out
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
            this.lblBuscaOut = new System.Windows.Forms.Label();
            this.btnConfirmarOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadreservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaDataSet1 = new PIM_Hotel.reservaDataSet1();
            this.cad_reservaTableAdapter = new PIM_Hotel.reservaDataSet1TableAdapters.cad_reservaTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscaOut
            // 
            this.lblBuscaOut.AutoSize = true;
            this.lblBuscaOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaOut.Location = new System.Drawing.Point(376, -12);
            this.lblBuscaOut.Name = "lblBuscaOut";
            this.lblBuscaOut.Size = new System.Drawing.Size(42, 13);
            this.lblBuscaOut.TabIndex = 62;
            this.lblBuscaOut.Text = "Busca";
            this.lblBuscaOut.Click += new System.EventHandler(this.lblBuscaOut_Click);
            // 
            // btnConfirmarOut
            // 
            this.btnConfirmarOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarOut.Location = new System.Drawing.Point(328, 330);
            this.btnConfirmarOut.Name = "btnConfirmarOut";
            this.btnConfirmarOut.Size = new System.Drawing.Size(96, 52);
            this.btnConfirmarOut.TabIndex = 87;
            this.btnConfirmarOut.Text = "Check-Out";
            this.btnConfirmarOut.UseVisualStyleBackColor = true;
            this.btnConfirmarOut.Click += new System.EventHandler(this.btnConfirmarOut_Click);
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
            this.dataGridView1.DataSource = this.cadreservaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 271);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            // 
            // numeroquartoDataGridViewTextBoxColumn
            // 
            this.numeroquartoDataGridViewTextBoxColumn.DataPropertyName = "numero_quarto";
            this.numeroquartoDataGridViewTextBoxColumn.HeaderText = "numero_quarto";
            this.numeroquartoDataGridViewTextBoxColumn.Name = "numeroquartoDataGridViewTextBoxColumn";
            // 
            // tipoquartoDataGridViewTextBoxColumn
            // 
            this.tipoquartoDataGridViewTextBoxColumn.DataPropertyName = "tipo_quarto";
            this.tipoquartoDataGridViewTextBoxColumn.HeaderText = "tipo_quarto";
            this.tipoquartoDataGridViewTextBoxColumn.Name = "tipoquartoDataGridViewTextBoxColumn";
            // 
            // cadreservaBindingSource
            // 
            this.cadreservaBindingSource.DataMember = "cad_reserva";
            this.cadreservaBindingSource.DataSource = this.reservaDataSet1;
            // 
            // reservaDataSet1
            // 
            this.reservaDataSet1.DataSetName = "reservaDataSet1";
            this.reservaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_reservaTableAdapter
            // 
            this.cad_reservaTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 17);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = ".";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(29, 17);
            this.checkBox2.TabIndex = 90;
            this.checkBox2.Text = ".";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(29, 17);
            this.checkBox3.TabIndex = 91;
            this.checkBox3.Text = ".";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 147);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(29, 17);
            this.checkBox4.TabIndex = 92;
            this.checkBox4.Text = ".";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 170);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(29, 17);
            this.checkBox5.TabIndex = 93;
            this.checkBox5.Text = ".";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(12, 193);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(29, 17);
            this.checkBox6.TabIndex = 94;
            this.checkBox6.Text = ".";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(12, 216);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(29, 17);
            this.checkBox7.TabIndex = 95;
            this.checkBox7.Text = ".";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(12, 239);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(29, 17);
            this.checkBox8.TabIndex = 96;
            this.checkBox8.Text = ".";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(12, 262);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(29, 17);
            this.checkBox9.TabIndex = 97;
            this.checkBox9.Text = ".";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(12, 285);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(29, 17);
            this.checkBox10.TabIndex = 98;
            this.checkBox10.Text = ".";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(12, 307);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(29, 17);
            this.checkBox11.TabIndex = 99;
            this.checkBox11.Text = ".";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // Check_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 407);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmarOut);
            this.Controls.Add(this.lblBuscaOut);
            this.Name = "Check_Out";
            this.Text = "Check_Out";
            this.Load += new System.EventHandler(this.Check_Out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscaOut;
        private System.Windows.Forms.Button btnConfirmarOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private reservaDataSet1 reservaDataSet1;
        private System.Windows.Forms.BindingSource cadreservaBindingSource;
        private reservaDataSet1TableAdapters.cad_reservaTableAdapter cad_reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox1;
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
    }
}