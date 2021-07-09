
namespace HelmetProblemWF
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
            this.btn_RandomHelmet = new System.Windows.Forms.Button();
            this.btn_FullSimulation = new System.Windows.Forms.Button();
            this.lst_Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_RandomHelmet
            // 
            this.btn_RandomHelmet.Location = new System.Drawing.Point(121, 61);
            this.btn_RandomHelmet.Name = "btn_RandomHelmet";
            this.btn_RandomHelmet.Size = new System.Drawing.Size(170, 29);
            this.btn_RandomHelmet.TabIndex = 0;
            this.btn_RandomHelmet.Text = "Get Random Helmet";
            this.btn_RandomHelmet.UseVisualStyleBackColor = true;
            this.btn_RandomHelmet.Click += new System.EventHandler(this.btn_RandomHelmet_Click);
            // 
            // btn_FullSimulation
            // 
            this.btn_FullSimulation.Location = new System.Drawing.Point(406, 61);
            this.btn_FullSimulation.Name = "btn_FullSimulation";
            this.btn_FullSimulation.Size = new System.Drawing.Size(170, 29);
            this.btn_FullSimulation.TabIndex = 1;
            this.btn_FullSimulation.Text = "Full Simulation";
            this.btn_FullSimulation.UseVisualStyleBackColor = true;
            this.btn_FullSimulation.Click += new System.EventHandler(this.btn_FullSimulation_Click);
            // 
            // lst_Output
            // 
            this.lst_Output.FormattingEnabled = true;
            this.lst_Output.ItemHeight = 20;
            this.lst_Output.Location = new System.Drawing.Point(121, 130);
            this.lst_Output.Name = "lst_Output";
            this.lst_Output.Size = new System.Drawing.Size(455, 284);
            this.lst_Output.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Output);
            this.Controls.Add(this.btn_FullSimulation);
            this.Controls.Add(this.btn_RandomHelmet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RandomHelmet;
        private System.Windows.Forms.Button btn_FullSimulation;
        private System.Windows.Forms.ListBox lst_Output;
    }
}

