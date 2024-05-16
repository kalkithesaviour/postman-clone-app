namespace PostmanCloneUI;

partial class Dashboard
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
        formHeader = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        resultsText = new TextBox();
        callApiButton = new Button();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        resultsLabel = new Label();
        httpVerbSelection = new ComboBox();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(35, -2);
        formHeader.Margin = new Padding(2, 0, 2, 0);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(372, 70);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.Location = new Point(35, 67);
        apiLabel.Margin = new Padding(2, 0, 2, 0);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(81, 56);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        apiLabel.Click += apiLabel_Click;
        // 
        // apiText
        // 
        apiText.Location = new Point(262, 68);
        apiText.Margin = new Padding(2);
        apiText.Name = "apiText";
        apiText.Size = new Size(469, 55);
        apiText.TabIndex = 2;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Location = new Point(35, 205);
        resultsText.Margin = new Padding(2);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(781, 376);
        resultsText.TabIndex = 3;
        // 
        // callApiButton
        // 
        callApiButton.Location = new Point(735, 68);
        callApiButton.Margin = new Padding(2);
        callApiButton.Name = "callApiButton";
        callApiButton.Size = new Size(81, 56);
        callApiButton.TabIndex = 4;
        callApiButton.Text = "Go";
        callApiButton.UseVisualStyleBackColor = true;
        callApiButton.Click += callApiButton_Click;
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.Transparent;
        statusStrip.ImageScalingSize = new Size(24, 24);
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 597);
        statusStrip.Name = "statusStrip";
        statusStrip.Padding = new Padding(1, 0, 10, 0);
        statusStrip.Size = new Size(849, 39);
        statusStrip.TabIndex = 5;
        statusStrip.Text = "statusStrip1";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(78, 32);
        systemStatus.Text = "Ready";
        // 
        // resultsLabel
        // 
        resultsLabel.AutoSize = true;
        resultsLabel.Location = new Point(35, 140);
        resultsLabel.Name = "resultsLabel";
        resultsLabel.Size = new Size(131, 48);
        resultsLabel.TabIndex = 6;
        resultsLabel.Text = "Results";
        // 
        // httpVerbSelection
        // 
        httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
        httpVerbSelection.FormattingEnabled = true;
        httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PATCH", "DELETE", "PUT" });
        httpVerbSelection.Location = new Point(121, 67);
        httpVerbSelection.Name = "httpVerbSelection";
        httpVerbSelection.Size = new Size(121, 56);
        httpVerbSelection.TabIndex = 7;
        httpVerbSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(849, 636);
        Controls.Add(httpVerbSelection);
        Controls.Add(resultsLabel);
        Controls.Add(statusStrip);
        Controls.Add(callApiButton);
        Controls.Add(resultsText);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Dashboard";
        Text = "Postman Clone by Vishal Singh Adhikari";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private TextBox resultsText;
    private Button callApiButton;
    private StatusStrip statusStrip;
    private Label resultsLabel;
    private ToolStripStatusLabel systemStatus;
    private ComboBox httpVerbSelection;
}
