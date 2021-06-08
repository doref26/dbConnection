
namespace form_A
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DELETE_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.Update_DB_btn = new System.Windows.Forms.Button();
            this.cancel_filter_btn = new System.Windows.Forms.Button();
            this.filter_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceFilterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DELETE_btn
            // 
            this.DELETE_btn.Location = new System.Drawing.Point(66, 79);
            this.DELETE_btn.Name = "DELETE_btn";
            this.DELETE_btn.Size = new System.Drawing.Size(75, 23);
            this.DELETE_btn.TabIndex = 1;
            this.DELETE_btn.Text = "DELETE";
            this.DELETE_btn.UseVisualStyleBackColor = true;
            this.DELETE_btn.Click += new System.EventHandler(this.DELETE_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(222, 79);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 2;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // Update_DB_btn
            // 
            this.Update_DB_btn.Location = new System.Drawing.Point(628, 197);
            this.Update_DB_btn.Name = "Update_DB_btn";
            this.Update_DB_btn.Size = new System.Drawing.Size(125, 58);
            this.Update_DB_btn.TabIndex = 3;
            this.Update_DB_btn.Text = "Update Data Base";
            this.Update_DB_btn.UseVisualStyleBackColor = true;
            this.Update_DB_btn.Click += new System.EventHandler(this.Update_DB_btn_Click);
            // 
            // cancel_filter_btn
            // 
            this.cancel_filter_btn.Location = new System.Drawing.Point(641, 122);
            this.cancel_filter_btn.Name = "cancel_filter_btn";
            this.cancel_filter_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_filter_btn.TabIndex = 4;
            this.cancel_filter_btn.Text = "Cancel Filter";
            this.cancel_filter_btn.UseVisualStyleBackColor = true;
            this.cancel_filter_btn.Click += new System.EventHandler(this.cancel_filter_btn_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.Location = new System.Drawing.Point(641, 84);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(75, 23);
            this.filter_btn.TabIndex = 5;
            this.filter_btn.Text = "Filter";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DeleteTextBox);
            this.groupBox1.Controls.Add(this.DELETE_btn);
            this.groupBox1.Location = new System.Drawing.Point(25, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 108);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Code:";
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(66, 32);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(88, 20);
            this.DeleteTextBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PriceTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DescTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.insert_btn);
            this.groupBox2.Location = new System.Drawing.Point(273, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 108);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(398, 32);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(239, 32);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(53, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // priceFilterTextBox
            // 
            this.priceFilterTextBox.Location = new System.Drawing.Point(688, 49);
            this.priceFilterTextBox.Name = "priceFilterTextBox";
            this.priceFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceFilterTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter above Price:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(588, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 129);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceFilterTextBox);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.cancel_filter_btn);
            this.Controls.Add(this.Update_DB_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DELETE_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button Update_DB_btn;
        private System.Windows.Forms.Button cancel_filter_btn;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox priceFilterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
    }
}

