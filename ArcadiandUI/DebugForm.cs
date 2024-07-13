using System;

class DebugForm : TitleBarForm
{
    private ScrollablePanel scrollablePanel2;
    private DropShadowPanel dropShadowPanel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private DropShadowPanel dropShadowPanel2;
    private SolidButton solidButton1;
    private ScrollablePanel scrollablePanel1;

    public override void InitializeComponents()
    {
        base.InitializeComponents();

        Text = "DebugForm";

        InitializeComponent();

        dropShadowPanel1.BottomShadow = new DropShadow() { ShadowDepth = 10 };
        dropShadowPanel1.TopShadow = new DropShadow() { ShadowDepth = 10 };

        dropShadowPanel2.LeftShadow = new DropShadow() { ShadowDepth = 10 };
        dropShadowPanel2.RightShadow = new DropShadow() { ShadowDepth = 10 };
    }

    private void InitializeComponent()
    {
            this.scrollablePanel1 = new ScrollablePanel();
            this.solidButton1 = new SolidButton();
            this.dropShadowPanel2 = new DropShadowPanel();
            this.scrollablePanel2 = new ScrollablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dropShadowPanel1 = new DropShadowPanel();
            this.scrollablePanel1.SuspendLayout();
            this.scrollablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollablePanel1
            // 
            this.scrollablePanel1.AutoScroll = true;
            this.scrollablePanel1.Controls.Add(this.solidButton1);
            this.scrollablePanel1.Controls.Add(this.dropShadowPanel2);
            this.scrollablePanel1.Controls.Add(this.scrollablePanel2);
            this.scrollablePanel1.Controls.Add(this.dropShadowPanel1);
            this.scrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollablePanel1.Location = new System.Drawing.Point(0, 34);
            this.scrollablePanel1.Name = "scrollablePanel1";
            this.scrollablePanel1.Size = new System.Drawing.Size(600, 426);
            this.scrollablePanel1.TabIndex = 2;
            // 
            // solidButton1
            // 
            this.solidButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.solidButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.solidButton1.HeldColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.solidButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.solidButton1.Location = new System.Drawing.Point(86, 98);
            this.solidButton1.Name = "solidButton1";
            this.solidButton1.Size = new System.Drawing.Size(75, 23);
            this.solidButton1.TabIndex = 2;
            this.solidButton1.Text = "solidButton1";
            this.solidButton1.Click += new System.EventHandler(this.solidButton1_Click);
            // 
            // dropShadowPanel2
            // 
            this.dropShadowPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dropShadowPanel2.Location = new System.Drawing.Point(161, 6);
            this.dropShadowPanel2.Name = "dropShadowPanel2";
            this.dropShadowPanel2.Size = new System.Drawing.Size(69, 78);
            this.dropShadowPanel2.TabIndex = 1;
            // 
            // scrollablePanel2
            // 
            this.scrollablePanel2.AutoScroll = true;
            this.scrollablePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.scrollablePanel2.Controls.Add(this.label4);
            this.scrollablePanel2.Controls.Add(this.label3);
            this.scrollablePanel2.Controls.Add(this.label2);
            this.scrollablePanel2.Controls.Add(this.label1);
            this.scrollablePanel2.Location = new System.Drawing.Point(7, 6);
            this.scrollablePanel2.Name = "scrollablePanel2";
            this.scrollablePanel2.Size = new System.Drawing.Size(73, 206);
            this.scrollablePanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dropShadowPanel1
            // 
            this.dropShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dropShadowPanel1.Location = new System.Drawing.Point(86, 6);
            this.dropShadowPanel1.Name = "dropShadowPanel1";
            this.dropShadowPanel1.Size = new System.Drawing.Size(69, 78);
            this.dropShadowPanel1.TabIndex = 0;
            // 
            // DebugForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.scrollablePanel1);
            this.Name = "DebugForm";
            this.Controls.SetChildIndex(this.scrollablePanel1, 0);
            this.scrollablePanel1.ResumeLayout(false);
            this.scrollablePanel2.ResumeLayout(false);
            this.scrollablePanel2.PerformLayout();
            this.ResumeLayout(false);

    }

    private void solidButton1_Click(object sender, System.EventArgs e)
    {
        Console.WriteLine("BUTTON CLICJ");
    }
}