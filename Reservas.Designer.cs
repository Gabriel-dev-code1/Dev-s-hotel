
namespace PIM_Hotel
{
    partial class Reservas
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
            this.btnFecharReserva = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadreservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaDataSet = new PIM_Hotel.reservaDataSet();
            this.cad_reservaTableAdapter = new PIM_Hotel.reservaDataSetTableAdapters.cad_reservaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecharReserva
            // 
            this.btnFecharReserva.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFecharReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharReserva.Location = new System.Drawing.Point(329, 346);
            this.btnFecharReserva.Name = "btnFecharReserva";
            this.btnFecharReserva.Size = new System.Drawing.Size(97, 52);
            this.btnFecharReserva.TabIndex = 113;
            this.btnFecharReserva.Text = "Fechar";
            this.btnFecharReserva.UseVisualStyleBackColor = false;
            this.btnFecharReserva.Click += new System.EventHandler(this.btnFecharReserva_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 294);
            this.dataGridView1.TabIndex = 115;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            this.cadreservaBindingSource.DataSource = this.reservaDataSet;
            // 
            // reservaDataSet
            // 
            this.reservaDataSet.DataSetName = "reservaDataSet";
            this.reservaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_reservaTableAdapter
            // 
            this.cad_reservaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Lista das reservas";
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFecharReserva);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFecharReserva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private reservaDataSet reservaDataSet;
        private System.Windows.Forms.BindingSource cadreservaBindingSource;
        private reservaDataSetTableAdapters.cad_reservaTableAdapter cad_reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}