namespace tao_easy_atk;

partial class Window
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

    private Button StartScriptButton = new Button();
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        // this.ClientSize = new System.Drawing.Size(800, 450);
        // this.ClientSize = new System.Drawing.Size(250, 350);
        this.ClientSize = new System.Drawing.Size(80, 60);
        this.Text = "TAO Easy ATK Beta 0.0";

        // Button StartScriptButton = new Button();
        StartScriptButton.Location = new Point(20, 15);

        // Set text inside the button
        StartScriptButton.Text = "開始";

        // Set the AutoSize property of the button
        StartScriptButton.AutoSize = true;

        StartScriptButton.Padding = new Padding(3);

        StartScriptButton.Click += new EventHandler(StartScriptButton_click);  

        // System.Drawing.Graphics formGraphics = this.CreateGraphics();
        // string drawString = "";
        // formGraphics.DrawString("開始するとエンターキーを\n押すだけで::atkと打ちます", new Font(new FontFamily("Times New Roman"), 16, FontStyle.Regular, GraphicsUnit.Pixel), new SolidBrush(Color.FromArgb(255, 0, 0, 255)), 10, 20);

        this.Controls.Add(StartScriptButton);
    }

    private void StartScriptButton_click(object sender, EventArgs e)  {
        Control control = this.Parent;
        Form buttonForm = this.FindForm();
        if (isRunning == true) {
            isRunning = false;
            StartScriptButton.Text = "開始";
        } else {
            isRunning = true;
            StartScriptButton.Text = "停止";
        }
        
    }

    #endregion
}
