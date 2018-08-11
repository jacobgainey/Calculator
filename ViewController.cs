using System;

using UIKit;

namespace Calculator
{
    public partial class ViewController : UIViewController
    {

        Int64 intScreenNumber = 0;
        Int64 intStoredNumber = 0;
        string strOperation = string.Empty;

        partial void Button_TouchUpInside(UIButton sender)
        {

            if (sender.Tag == 11) { ClearScreen(); return; } // clear the screen
            if (sender.Tag == 12) { ClearScreen(); return; } // + / -
            if (sender.Tag == 13) { ClearScreen(); return; } // %

            if (sender.TitleLabel.Text == "=")
            {
                Int64 x = Convert.ToInt64(screen.Text);
                switch (strOperation)
                {
                    case "-":
                        screen.Text = Convert.ToString(intStoredNumber - intScreenNumber);
                        break;
                    case "+":
                        screen.Text = Convert.ToString(intStoredNumber + intScreenNumber);
                        break;
                    default:
                        break;
                }
                intScreenNumber = Convert.ToInt64(screen.Text);
            }
            else
            {
                strOperation = sender.TitleLabel.Text;
                intStoredNumber = intScreenNumber;
                screen.Text = string.Empty;
                
            }
            //operation.Text = operation.Text + strOperation;
        }

        partial void Number_TouchUpInside(UIButton sender)
        {
            screen.Text = screen.Text + Convert.ToString(sender.Tag);
            operation.Text = operation.Text + Convert.ToString(sender.Tag);
            intScreenNumber = Convert.ToInt64(screen.Text);
            screen.Text = Convert.ToString(intScreenNumber);
        }

        private void ClearScreen()
        {
            intScreenNumber = 0;
            intStoredNumber = 0;
            screen.Text = string.Empty;
            operation.Text = string.Empty;
            strOperation = string.Empty;
            //operation.Text = "All your base are belongs to us!";
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            ClearScreen();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
