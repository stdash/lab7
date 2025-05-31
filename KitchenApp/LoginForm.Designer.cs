namespace KitchenApp
{
    partial class LoginForm
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
            panel1 = new Panel();
            loginPanel = new Panel();
            stuffButton = new Button();
            clientButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(clientButton);
            panel1.Controls.Add(stuffButton);
            panel1.Location = new Point(11, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 220);
            panel1.TabIndex = 0;
            // 
            // loginPanel
            // 
            loginPanel.Location = new Point(11, 280);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1215, 370);
            loginPanel.TabIndex = 1;
            // 
            // stuffButton
            // 
            stuffButton.Location = new Point(16, 36);
            stuffButton.Name = "stuffButton";
            stuffButton.Size = new Size(314, 150);
            stuffButton.TabIndex = 0;
            stuffButton.Text = "Сотрудник";
            stuffButton.UseVisualStyleBackColor = true;
            stuffButton.Click += stuffButton_Click;
            // 
            // clientButton
            // 
            clientButton.Location = new Point(880, 36);
            clientButton.Name = "clientButton";
            clientButton.Size = new Size(314, 150);
            clientButton.TabIndex = 1;
            clientButton.Text = "Клиент";
            clientButton.UseVisualStyleBackColor = true;
            clientButton.Click += clientButton_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(1250, 680);
            Controls.Add(loginPanel);
            Controls.Add(panel1);
            Name = "LoginForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button clientButton;
        private Button stuffButton;
        private Panel loginPanel;
    }
}
