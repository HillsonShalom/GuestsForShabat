namespace GuestsForShabat
{
    partial class HostForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_category = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.list_categories = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "מארח - הכנס קטגוריות";
            // 
            // text_category
            // 
            this.text_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.text_category.Location = new System.Drawing.Point(107, 109);
            this.text_category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_category.Name = "text_category";
            this.text_category.Size = new System.Drawing.Size(180, 32);
            this.text_category.TabIndex = 1;
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_enter.Location = new System.Drawing.Point(146, 162);
            this.button_enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(96, 33);
            this.button_enter.TabIndex = 2;
            this.button_enter.Text = "הכנס";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // list_categories
            // 
            this.list_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.list_categories.HideSelection = false;
            this.list_categories.Location = new System.Drawing.Point(107, 217);
            this.list_categories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_categories.Name = "list_categories";
            this.list_categories.RightToLeftLayout = true;
            this.list_categories.Size = new System.Drawing.Size(175, 235);
            this.list_categories.TabIndex = 3;
            this.list_categories.UseCompatibleStateImageBehavior = false;
            this.list_categories.View = System.Windows.Forms.View.List;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 497);
            this.Controls.Add(this.list_categories);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.text_category);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HostForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "HostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_category;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.ListView list_categories;
    }
}