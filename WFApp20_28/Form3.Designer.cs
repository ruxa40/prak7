
namespace WFApp20_28
{
    partial class Form3
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
            this.иДзаказыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествовРулонахDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьрубDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обоиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._wallpaper__1_DataSet = new WFApp20_28._wallpaper__1_DataSet();
            this.заказыTableAdapter = new WFApp20_28._wallpaper__1_DataSetTableAdapters.заказыTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.иДобоиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерсмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рисунокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьрубDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обоиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обоиTableAdapter = new WFApp20_28._wallpaper__1_DataSetTableAdapters.ОбоиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._wallpaper__1_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обоиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДзаказыDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.количествовРулонахDataGridViewTextBoxColumn,
            this.стоимостьрубDataGridViewTextBoxColumn,
            this.обоиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 98);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДзаказыDataGridViewTextBoxColumn
            // 
            this.иДзаказыDataGridViewTextBoxColumn.DataPropertyName = "ИД_заказы";
            this.иДзаказыDataGridViewTextBoxColumn.HeaderText = "ИД_заказы";
            this.иДзаказыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДзаказыDataGridViewTextBoxColumn.Name = "иДзаказыDataGridViewTextBoxColumn";
            this.иДзаказыDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествовРулонахDataGridViewTextBoxColumn
            // 
            this.количествовРулонахDataGridViewTextBoxColumn.DataPropertyName = "количество (в рулонах)";
            this.количествовРулонахDataGridViewTextBoxColumn.HeaderText = "количество (в рулонах)";
            this.количествовРулонахDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествовРулонахDataGridViewTextBoxColumn.Name = "количествовРулонахDataGridViewTextBoxColumn";
            this.количествовРулонахDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьрубDataGridViewTextBoxColumn
            // 
            this.стоимостьрубDataGridViewTextBoxColumn.DataPropertyName = "стоимость (руб)";
            this.стоимостьрубDataGridViewTextBoxColumn.HeaderText = "стоимость (руб)";
            this.стоимостьрубDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьрубDataGridViewTextBoxColumn.Name = "стоимостьрубDataGridViewTextBoxColumn";
            this.стоимостьрубDataGridViewTextBoxColumn.Width = 125;
            // 
            // обоиDataGridViewTextBoxColumn
            // 
            this.обоиDataGridViewTextBoxColumn.DataPropertyName = "обои";
            this.обоиDataGridViewTextBoxColumn.HeaderText = "обои";
            this.обоиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.обоиDataGridViewTextBoxColumn.Name = "обоиDataGridViewTextBoxColumn";
            this.обоиDataGridViewTextBoxColumn.Width = 125;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "заказы";
            this.заказыBindingSource.DataSource = this._wallpaper__1_DataSet;
            // 
            // _wallpaper__1_DataSet
            // 
            this._wallpaper__1_DataSet.DataSetName = "_wallpaper__1_DataSet";
            this._wallpaper__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДобоиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.материалDataGridViewTextBoxColumn,
            this.размерсмDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.рисунокDataGridViewTextBoxColumn,
            this.стоимостьрубDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.обоиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(30, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(758, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // иДобоиDataGridViewTextBoxColumn
            // 
            this.иДобоиDataGridViewTextBoxColumn.DataPropertyName = "ИД_обои";
            this.иДобоиDataGridViewTextBoxColumn.HeaderText = "ИД_обои";
            this.иДобоиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДобоиDataGridViewTextBoxColumn.Name = "иДобоиDataGridViewTextBoxColumn";
            this.иДобоиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // материалDataGridViewTextBoxColumn
            // 
            this.материалDataGridViewTextBoxColumn.DataPropertyName = "материал";
            this.материалDataGridViewTextBoxColumn.HeaderText = "материал";
            this.материалDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.материалDataGridViewTextBoxColumn.Name = "материалDataGridViewTextBoxColumn";
            this.материалDataGridViewTextBoxColumn.Width = 125;
            // 
            // размерсмDataGridViewTextBoxColumn
            // 
            this.размерсмDataGridViewTextBoxColumn.DataPropertyName = "размер (см)";
            this.размерсмDataGridViewTextBoxColumn.HeaderText = "размер (см)";
            this.размерсмDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.размерсмDataGridViewTextBoxColumn.Name = "размерсмDataGridViewTextBoxColumn";
            this.размерсмDataGridViewTextBoxColumn.Width = 125;
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "цвет";
            this.цветDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            this.цветDataGridViewTextBoxColumn.Width = 125;
            // 
            // рисунокDataGridViewTextBoxColumn
            // 
            this.рисунокDataGridViewTextBoxColumn.DataPropertyName = "рисунок";
            this.рисунокDataGridViewTextBoxColumn.HeaderText = "рисунок";
            this.рисунокDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рисунокDataGridViewTextBoxColumn.Name = "рисунокDataGridViewTextBoxColumn";
            this.рисунокDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьрубDataGridViewTextBoxColumn1
            // 
            this.стоимостьрубDataGridViewTextBoxColumn1.DataPropertyName = "стоимость (руб)";
            this.стоимостьрубDataGridViewTextBoxColumn1.HeaderText = "стоимость (руб)";
            this.стоимостьрубDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.стоимостьрубDataGridViewTextBoxColumn1.Name = "стоимостьрубDataGridViewTextBoxColumn1";
            this.стоимостьрубDataGridViewTextBoxColumn1.Width = 125;
            // 
            // обоиBindingSource
            // 
            this.обоиBindingSource.DataMember = "Обои";
            this.обоиBindingSource.DataSource = this._wallpaper__1_DataSet;
            // 
            // обоиTableAdapter
            // 
            this.обоиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заказы";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обои";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(41, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(41, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._wallpaper__1_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обоиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _wallpaper__1_DataSet _wallpaper__1_DataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private _wallpaper__1_DataSetTableAdapters.заказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДзаказыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествовРулонахDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьрубDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обоиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource обоиBindingSource;
        private _wallpaper__1_DataSetTableAdapters.ОбоиTableAdapter обоиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДобоиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материалDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерсмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рисунокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьрубDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}