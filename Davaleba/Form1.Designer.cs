namespace Davaleba;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

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
        lblA = new Label();
        lblB = new Label();
        lblC = new Label();
        txtA = new TextBox();
        txtB = new TextBox();
        txtC = new TextBox();
        btnCalc = new Button();
        txtResult = new TextBox();
        SuspendLayout();
        // 
        // lblA
        // 
        lblA.Location = new Point(20, 20);
        lblA.Name = "lblA";
        lblA.Size = new Size(40, 23);
        lblA.Text = "a =";
        // 
        // lblB
        // 
        lblB.Location = new Point(20, 60);
        lblB.Name = "lblB";
        lblB.Size = new Size(40, 23);
        lblB.Text = "b =";
        // 
        // lblC
        // 
        lblC.Location = new Point(20, 100);
        lblC.Name = "lblC";
        lblC.Size = new Size(40, 23);
        lblC.Text = "c =";
        // 
        // txtA
        // 
        txtA.Location = new Point(70, 20);
        txtA.Name = "txtA";
        txtA.Size = new Size(150, 23);
        // 
        // txtB
        // 
        txtB.Location = new Point(70, 60);
        txtB.Name = "txtB";
        txtB.Size = new Size(150, 23);
        // 
        // txtC
        // 
        txtC.Location = new Point(70, 100);
        txtC.Name = "txtC";
        txtC.Size = new Size(150, 23);
        // 
        // btnCalc
        // 
        btnCalc.Location = new Point(240, 20);
        btnCalc.Name = "btnCalc";
        btnCalc.Size = new Size(140, 103);
        btnCalc.Text = "გამოთვლა";
        btnCalc.UseVisualStyleBackColor = true;
        btnCalc.Click += btnCalc_Click;
        // 
        // txtResult
        // 
        txtResult.Location = new Point(20, 150);
        txtResult.Multiline = true;
        txtResult.Name = "txtResult";
        txtResult.ReadOnly = true;
        txtResult.ScrollBars = ScrollBars.Vertical;
        txtResult.Size = new Size(360, 150);
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(404, 321);
        Controls.Add(lblA);
        Controls.Add(lblB);
        Controls.Add(lblC);
        Controls.Add(txtA);
        Controls.Add(txtB);
        Controls.Add(txtC);
        Controls.Add(btnCalc);
        Controls.Add(txtResult);
        Name = "Form1";
        Text = "დავალება 2.1";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblA;
    private Label lblB;
    private Label lblC;
    private TextBox txtA;
    private TextBox txtB;
    private TextBox txtC;
    private Button btnCalc;
    private TextBox txtResult;
}
