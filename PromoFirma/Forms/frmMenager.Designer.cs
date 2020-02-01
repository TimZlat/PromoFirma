namespace PromoFirma.Forms
{
    partial class frmMenager
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.тСотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promoFirmaDataSet = new PromoFirma.PromoFirmaDataSet();
            this.z2SotrActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.т_СотрудникTableAdapter = new PromoFirma.PromoFirmaDataSetTableAdapters.Т_СотрудникTableAdapter();
            this.z2_Sotr_ActionTableAdapter = new PromoFirma.PromoFirmaDataSetTableAdapters.z2_Sotr_ActionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тСотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoFirmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z2SotrActionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(12, 124);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(628, 216);
            this.dgView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(171, 361);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(131, 32);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbBox1
            // 
            this.cmbBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.тСотрудникBindingSource, "Фамилия", true));
            this.cmbBox1.DataSource = this.z2SotrActionBindingSource;
            this.cmbBox1.DisplayMember = "Фамилия";
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Location = new System.Drawing.Point(93, 70);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(223, 24);
            this.cmbBox1.TabIndex = 4;
            this.cmbBox1.ValueMember = "КодСотрудника";
            // 
            // тСотрудникBindingSource
            // 
            this.тСотрудникBindingSource.DataMember = "Т_Сотрудник";
            this.тСотрудникBindingSource.DataSource = this.promoFirmaDataSet;
            // 
            // promoFirmaDataSet
            // 
            this.promoFirmaDataSet.DataSetName = "PromoFirmaDataSet";
            this.promoFirmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // z2SotrActionBindingSource
            // 
            this.z2SotrActionBindingSource.DataMember = "z2_Sotr_Action";
            this.z2SotrActionBindingSource.DataSource = this.promoFirmaDataSet;
            // 
            // т_СотрудникTableAdapter
            // 
            this.т_СотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // z2_Sotr_ActionTableAdapter
            // 
            this.z2_Sotr_ActionTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 406);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenager";
            this.Text = "Окно Менеджера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenager_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тСотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoFirmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z2SotrActionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBox1;
        private PromoFirmaDataSet promoFirmaDataSet;
        private System.Windows.Forms.BindingSource тСотрудникBindingSource;
        private PromoFirmaDataSetTableAdapters.Т_СотрудникTableAdapter т_СотрудникTableAdapter;
        private System.Windows.Forms.BindingSource z2SotrActionBindingSource;
        private PromoFirmaDataSetTableAdapters.z2_Sotr_ActionTableAdapter z2_Sotr_ActionTableAdapter;
    }
}