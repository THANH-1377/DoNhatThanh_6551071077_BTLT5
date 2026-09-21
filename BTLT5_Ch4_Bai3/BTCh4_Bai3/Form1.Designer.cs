namespace ToDoListDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCongViecMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstCongViec;
        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.ContextMenuStrip cmsCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuHoanThanh;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaMotCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaTatCa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTop = new System.Windows.Forms.Panel();
            btnThem = new System.Windows.Forms.Button();
            txtCongViecMoi = new System.Windows.Forms.TextBox();
            lstCongViec = new System.Windows.Forms.ListBox();
            cmsCongViec = new System.Windows.Forms.ContextMenuStrip(components);
            mnuHoanThanh = new System.Windows.Forms.ToolStripMenuItem();
            mnuXoaMotCongViec = new System.Windows.Forms.ToolStripMenuItem();
            mnuXoaTatCa = new System.Windows.Forms.ToolStripMenuItem();
            pnlTop.SuspendLayout();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnThem);
            pnlTop.Controls.Add(txtCongViecMoi);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            pnlTop.Size = new System.Drawing.Size(571, 67);
            pnlTop.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(446, 17);
            btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(103, 33);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new System.Drawing.Point(11, 19);
            txtCongViecMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new System.Drawing.Size(422, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            lstCongViec.Location = new System.Drawing.Point(0, 67);
            lstCongViec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new System.Drawing.Size(571, 400);
            lstCongViec.TabIndex = 1;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new System.Drawing.Size(20, 20);
            cmsCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuHoanThanh, mnuXoaMotCongViec, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new System.Drawing.Size(221, 76);
            // 
            // mnuHoanThanh
            // 
            mnuHoanThanh.Name = "mnuHoanThanh";
            mnuHoanThanh.Size = new System.Drawing.Size(220, 24);
            mnuHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuHoanThanh.Click += mnuHoanThanh_Click;
            // 
            // mnuXoaMotCongViec
            // 
            mnuXoaMotCongViec.Name = "mnuXoaMotCongViec";
            mnuXoaMotCongViec.Size = new System.Drawing.Size(220, 24);
            mnuXoaMotCongViec.Text = "Xóa công việc này";
            mnuXoaMotCongViec.Click += mnuXoaMotCongViec_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new System.Drawing.Size(220, 24);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(571, 467);
            Controls.Add(lstCongViec);
            Controls.Add(pnlTop);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Danh sách việc cần làm hằng ngày";
            Load += Form1_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
