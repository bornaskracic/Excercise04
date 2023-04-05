using Common.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class ContactViewUtility
    {
        internal static FlowLayoutPanel CreatePanel(Contact contact)
        {
            // label for name, label for surname and label for email
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                BorderStyle = BorderStyle.FixedSingle,
                FlowDirection = FlowDirection.TopDown,
                Tag = contact.Id
            };
            panel.Controls.Add(CreateLabel(contact.FirstName));
            panel.Controls.Add(CreateLabel(contact.LastName));
            panel.Controls.Add(CreateLinkLabel(contact.Email));

            return panel;
        }

        private static Label CreateLabel(string text)
         => new Label
         {
             Margin = new Padding(0, 5, 0, 5),
             AutoSize = true,
             Text = text
         };

        private static LinkLabel CreateLinkLabel(string text)
        {
            var label = new LinkLabel
            {
                AutoSize = true,
                Text = text
            };
            label.Click += (sender, ea) =>
            {
                var lbl = sender as LinkLabel;
                //Process.Start($"mailto:{lbl.Text}");
            };

            return label;
        }


    }
}
