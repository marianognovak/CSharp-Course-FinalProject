namespace View
{
    partial class Stock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbArticles = new System.Windows.Forms.PictureBox();
            this.lblField = new System.Windows.Forms.Label();
            this.lblCriterion = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.cbxCriterion = new System.Windows.Forms.ComboBox();
            this.txtbFilter = new System.Windows.Forms.TextBox();
            this.grbxFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSeeDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticles)).BeginInit();
            this.grbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStock.Location = new System.Drawing.Point(12, 72);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(752, 473);
            this.dgvStock.StandardTab = true;
            this.dgvStock.TabIndex = 10;
            this.dgvStock.TabStop = false;
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvStock_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(770, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar artículo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(770, 433);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(300, 53);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modificar artículo";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(770, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(300, 53);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar artículo";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbArticles
            // 
            this.pbArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArticles.Location = new System.Drawing.Point(770, 9);
            this.pbArticles.Name = "pbArticles";
            this.pbArticles.Size = new System.Drawing.Size(300, 300);
            this.pbArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticles.TabIndex = 4;
            this.pbArticles.TabStop = false;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(6, 26);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(43, 13);
            this.lblField.TabIndex = 11;
            this.lblField.Text = "Campo:";
            // 
            // lblCriterion
            // 
            this.lblCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriterion.AutoSize = true;
            this.lblCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterion.Location = new System.Drawing.Point(165, 26);
            this.lblCriterion.Name = "lblCriterion";
            this.lblCriterion.Size = new System.Drawing.Size(42, 13);
            this.lblCriterion.TabIndex = 12;
            this.lblCriterion.Text = "Criterio:";
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(334, 26);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "Filtro:";
            // 
            // cbxField
            // 
            this.cbxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Location = new System.Drawing.Point(54, 23);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(98, 21);
            this.cbxField.TabIndex = 0;
            this.cbxField.SelectedIndexChanged += new System.EventHandler(this.cbxField_SelectedIndexChanged);
            // 
            // cbxCriterion
            // 
            this.cbxCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCriterion.FormattingEnabled = true;
            this.cbxCriterion.Location = new System.Drawing.Point(213, 23);
            this.cbxCriterion.Name = "cbxCriterion";
            this.cbxCriterion.Size = new System.Drawing.Size(100, 21);
            this.cbxCriterion.TabIndex = 1;
            // 
            // txtbFilter
            // 
            this.txtbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbFilter.Location = new System.Drawing.Point(372, 23);
            this.txtbFilter.Name = "txtbFilter";
            this.txtbFilter.Size = new System.Drawing.Size(173, 20);
            this.txtbFilter.TabIndex = 2;
            // 
            // grbxFilter
            // 
            this.grbxFilter.Controls.Add(this.btnResetFilter);
            this.grbxFilter.Controls.Add(this.btnFilter);
            this.grbxFilter.Controls.Add(this.lblField);
            this.grbxFilter.Controls.Add(this.txtbFilter);
            this.grbxFilter.Controls.Add(this.lblFilter);
            this.grbxFilter.Controls.Add(this.cbxField);
            this.grbxFilter.Controls.Add(this.cbxCriterion);
            this.grbxFilter.Controls.Add(this.lblCriterion);
            this.grbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxFilter.Location = new System.Drawing.Point(12, 6);
            this.grbxFilter.Name = "grbxFilter";
            this.grbxFilter.Size = new System.Drawing.Size(752, 60);
            this.grbxFilter.TabIndex = 0;
            this.grbxFilter.TabStop = false;
            this.grbxFilter.Text = "Filtrar";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.Location = new System.Drawing.Point(659, 15);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(87, 34);
            this.btnResetFilter.TabIndex = 4;
            this.btnResetFilter.Text = "Reiniciar filtros";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(566, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(87, 34);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSeeDetails
            // 
            this.btnSeeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeDetails.Location = new System.Drawing.Point(770, 315);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(300, 53);
            this.btnSeeDetails.TabIndex = 11;
            this.btnSeeDetails.Text = "Ver detalle";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            this.btnSeeDetails.Click += new System.EventHandler(this.btnSeeDetails_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 550);
            this.Controls.Add(this.btnSeeDetails);
            this.Controls.Add(this.grbxFilter);
            this.Controls.Add(this.pbArticles);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStock);
            this.MinimumSize = new System.Drawing.Size(1098, 538);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticles)).EndInit();
            this.grbxFilter.ResumeLayout(false);
            this.grbxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbArticles;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblCriterion;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.ComboBox cbxCriterion;
        private System.Windows.Forms.TextBox txtbFilter;
        private System.Windows.Forms.GroupBox grbxFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnSeeDetails;
    }
}