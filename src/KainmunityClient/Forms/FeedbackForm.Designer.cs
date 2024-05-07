﻿using System.Windows.Forms;

namespace KainmunityClient.Forms
{
    partial class FeedbackForm
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
            this.feedbackContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.head = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.newFeedback = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // feedbackContainer
            // 
            this.feedbackContainer.AutoScroll = true;
            this.feedbackContainer.Enabled = false;
            this.feedbackContainer.Location = new System.Drawing.Point(115, 96);
            this.feedbackContainer.Name = "feedbackContainer";
            this.feedbackContainer.Size = new System.Drawing.Size(576, 334);
            this.feedbackContainer.TabIndex = 6;
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.head.Controls.Add(this.back);
            this.head.Controls.Add(this.title);
            this.head.Location = new System.Drawing.Point(115, 12);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(576, 78);
            this.head.TabIndex = 5;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.back.Location = new System.Drawing.Point(10, 9);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(52, 23);
            this.back.TabIndex = 17;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.title.Location = new System.Drawing.Point(188, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 60);
            this.title.TabIndex = 2;
            this.title.Text = "FEEDBACK";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newFeedback
            // 
            this.newFeedback.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFeedback.Location = new System.Drawing.Point(115, 436);
            this.newFeedback.Multiline = true;
            this.newFeedback.Name = "newFeedback";
            this.newFeedback.Size = new System.Drawing.Size(477, 54);
            this.newFeedback.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(598, 436);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(93, 54);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(176)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(802, 502);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newFeedback);
            this.Controls.Add(this.feedbackContainer);
            this.Controls.Add(this.head);
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel feedbackContainer;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox newFeedback;
        private System.Windows.Forms.Button submitButton;
    }
}