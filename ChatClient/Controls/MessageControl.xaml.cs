using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatClient.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        } 

        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        public MessageControl(Boolean leftHand, string text)
        {
            InitializeComponent();
            if (leftHand)
                SetLeftMessage(text);
            else
                SetRigthMessage(text);
        } 


        public void SetLeftMessage(string text)
        {
            this.leftMessage.Visibility = Visibility.Visible; 
            this.leftDate.Content = DateTime.Now;
            this.rightDate.Content = null;
            this.leftSide.Text = text;
            this.rightSide.Text = string.Empty; 
        }

        public void SetRigthMessage(string text)
        { 
            this.rightMessage.Visibility = Visibility.Visible;
            this.leftDate.Content = null;
            this.rightDate.Content = DateTime.Now;
            this.leftSide.Text = string.Empty;
            this.rightSide.Text = text;
        }

        public void CleanMessage()
        {
            this.leftMessage.Visibility = Visibility.Hidden;
            this.rightMessage.Visibility = Visibility.Hidden;
            this.leftDate.Content = null;
            this.rightDate.Content = null;
            this.leftSide.Text = string.Empty;
            this.rightSide.Text = string.Empty;
        }
         

    }
}
