
namespace PIM_Hotel
{
    partial class Relatorio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.reservaDataSet4 = new PIM_Hotel.reservaDataSet4();
            this.cadreservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_reservaTableAdapter = new PIM_Hotel.reservaDataSet4TableAdapters.cad_reservaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoquartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cad_funcDataSet1 = new PIM_Hotel.cad_funcDataSet1();
            this.funcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcTableAdapter = new PIM_Hotel.cad_funcDataSet1TableAdapters.funcTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_funcDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório: ultimas reservas feitas no mês de novembro";
            // 
            // reservaDataSet4
            // 
            this.reservaDataSet4.DataSetName = "reservaDataSet4";
            this.reservaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadreservaBindingSource
            // 
            this.cadreservaBindingSource.DataMember = "cad_reserva";
            this.cadreservaBindingSource.DataSource = this.reservaDataSet4;
            // 
            // cad_reservaTableAdapter
            // 
            this.cad_reservaTableAdapter.ClearBeforeFill = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Relatório ultimos funcionários cadastrados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.cpfDataGridViewTextBoxColumn,
            this.datanascDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.funcBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(39, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(679, 166);
            this.dataGridView2.TabIndex = 3;
            // 
            // cad_funcDataSet1
            // 
            this.cad_funcDataSet1.DataSetName = "cad_funcDataSet1";
            this.cad_funcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcBindingSource
            // 
            this.funcBindingSource.DataMember = "func";
            this.funcBindingSource.DataSource = this.cad_funcDataSet1;
            // 
            // funcTableAdapter
            // 
            this.funcTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // datanascDataGridViewTextBoxColumn
            // 
            this.datanascDataGridViewTextBoxColumn.DataPropertyName = "data_nasc";
            this.datanascDataGridViewTextBoxColumn.HeaderText = "data_nasc";
            this.datanascDataGridViewTextBoxColumn.Name = "datanascDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn1
            // 
            this.rgDataGridViewTextBoxColumn1.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn1.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn1.Name = "rgDataGridViewTextBoxColumn1";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 471);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadreservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_funcDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private reservaDataSet4 reservaDataSet4;
        private System.Windows.Forms.BindingSource cadreservaBindingSource;
        private reservaDataSet4TableAdapters.cad_reservaTableAdapter cad_reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoquartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private cad_funcDataSet1 cad_funcDataSet1;
        private System.Windows.Forms.BindingSource funcBindingSource;
        private cad_funcDataSet1TableAdapters.funcTableAdapter funcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn1;
    }
}