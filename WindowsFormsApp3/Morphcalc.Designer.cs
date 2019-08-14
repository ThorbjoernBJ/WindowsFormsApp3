namespace WindowsFormsApp3
{
    partial class Morphcalc
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
            this.Merge = new System.Windows.Forms.Button();
            this.MorphText = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.listMorph = new System.Windows.Forms.ListBox();
            this.listcombo = new System.Windows.Forms.ListBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(294, 155);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 52);
            this.Merge.TabIndex = 0;
            this.Merge.Text = "Merge morphs";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.MixFromlistMorph);
            // 
            // MorphText
            // 
            this.MorphText.Location = new System.Drawing.Point(28, 118);
            this.MorphText.Name = "MorphText";
            this.MorphText.Size = new System.Drawing.Size(102, 22);
            this.MorphText.TabIndex = 2;
            this.MorphText.Text = "Type morph";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(28, 146);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add morph";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.AddFromMorphText);
            // 
            // listMorph
            // 
            this.listMorph.FormattingEnabled = true;
            this.listMorph.ItemHeight = 16;
            this.listMorph.Location = new System.Drawing.Point(136, 64);
            this.listMorph.Name = "listMorph";
            this.listMorph.Size = new System.Drawing.Size(128, 196);
            this.listMorph.TabIndex = 5;
            // 
            // listcombo
            // 
            this.listcombo.FormattingEnabled = true;
            this.listcombo.ItemHeight = 16;
            this.listcombo.Location = new System.Drawing.Point(425, 85);
            this.listcombo.Name = "listcombo";
            this.listcombo.Size = new System.Drawing.Size(165, 212);
            this.listcombo.TabIndex = 6;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(28, 176);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(102, 42);
            this.btnremove.TabIndex = 7;
            this.btnremove.Text = "Remove a morph";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.RemoveFromlistMorph);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(28, 224);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 23);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.ClearFromlistMorph);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.listcombo);
            this.Controls.Add(this.listMorph);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.MorphText);
            this.Controls.Add(this.Merge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.TextBox MorphText;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox listMorph;
        private System.Windows.Forms.ListBox listcombo;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnclear;
    }
}

