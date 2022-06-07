
namespace PIM_Hotel
{
    partial class Hóspedes
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
            this.cadhospBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new PIM_Hotel.hotelDataSet();
            this.cad_hospTableAdapter = new PIM_Hotel.hotelDataSetTableAdapters.cad_hospTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelDataSet1 = new PIM_Hotel.hotelDataSet1();
            this.cadhospBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cad_hospTableAdapter1 = new PIM_Hotel.hotelDataSet1TableAdapters.cad_hospTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelDataSet2 = new PIM_Hotel.hotelDataSet2();
            this.cadhospBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cad_hospTableAdapter2 = new PIM_Hotel.hotelDataSet2TableAdapters.cad_hospTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cadhospBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadhospBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadhospBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // cadhospBindingSource
            // 
            this.cadhospBindingSource.DataMember = "cad_hosp";
            this.cadhospBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_hospTableAdapter
            // 
            this.cad_hospTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "lista de hóspedes do hotel";
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadhospBindingSource1
            // 
            this.cadhospBindingSource1.DataMember = "cad_hosp";
            this.cadhospBindingSource1.DataSource = this.hotelDataSet1;
            // 
            // cad_hospTableAdapter1
            // 
            this.cad_hospTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datanascDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadhospBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 349);
            this.dataGridView1.TabIndex = 97;
            // 
            // hotelDataSet2
            // 
            this.hotelDataSet2.DataSetName = "hotelDataSet2";
            this.hotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadhospBindingSource2
            // 
            this.cadhospBindingSource2.DataMember = "cad_hosp";
            this.cadhospBindingSource2.DataSource = this.hotelDataSet2;
            // 
            // cad_hospTableAdapter2
            // 
            this.cad_hospTableAdapter2.ClearBeforeFill = true;
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
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Hóspedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Hóspedes";
            this.Text = "Hóspedes";
            this.Load += new System.EventHandler(this.Hóspedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadhospBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadhospBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadhospBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource cadhospBindingSource;
        private hotelDataSetTableAdapters.cad_hospTableAdapter cad_hospTableAdapter;
        private System.Windows.Forms.Label label1;
        private hotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource cadhospBindingSource1;
        private hotelDataSet1TableAdapters.cad_hospTableAdapter cad_hospTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hotelDataSet2 hotelDataSet2;
        private System.Windows.Forms.BindingSource cadhospBindingSource2;
        private hotelDataSet2TableAdapters.cad_hospTableAdapter cad_hospTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}