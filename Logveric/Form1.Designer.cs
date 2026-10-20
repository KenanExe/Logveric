namespace Logveric
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btn_Left = new Button();
            btn_Right = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbl_LogSize = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 891);
            dataGridView1.TabIndex = 0;
            // 
            // btn_Left
            // 
            btn_Left.Location = new Point(101, 3);
            btn_Left.Name = "btn_Left";
            btn_Left.Size = new Size(35, 35);
            btn_Left.TabIndex = 1;
            btn_Left.Text = "<";
            btn_Left.UseVisualStyleBackColor = true;
            // 
            // btn_Right
            // 
            btn_Right.Location = new Point(142, 3);
            btn_Right.Name = "btn_Right";
            btn_Right.Size = new Size(35, 35);
            btn_Right.TabIndex = 2;
            btn_Right.Text = ">";
            btn_Right.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lbl_LogSize);
            flowLayoutPanel1.Controls.Add(btn_Left);
            flowLayoutPanel1.Controls.Add(btn_Right);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 900);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(575, 41);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lbl_LogSize
            // 
            lbl_LogSize.AutoSize = true;
            lbl_LogSize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_LogSize.Location = new Point(3, 9);
            lbl_LogSize.Margin = new Padding(3, 9, 3, 3);
            lbl_LogSize.Name = "lbl_LogSize";
            lbl_LogSize.Size = new Size(92, 20);
            lbl_LogSize.TabIndex = 3;
            lbl_LogSize.Text = "Showing 0/0";
            lbl_LogSize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(183, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 35);
            button1.TabIndex = 4;
            button1.Text = "import";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 941);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Left;
        private Button btn_Right;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbl_LogSize;
        private Button button1;
    }
}
