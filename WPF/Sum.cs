using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class Sum : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string num1;
        private string num2;
        private string result;

        public string Num1
        {
            get { return num1; }
            set {
                int number;
                bool parsed = int.TryParse(value, out number);
                if (parsed)
                {
                    num1 = value;
                }
                OnPropertyChange("Num1");
                OnPropertyChange("Result");
            }
        }
        public string Num2
        {
            get { return num2; }
            set
            {
                int number;
                bool parsed = int.TryParse(value, out number);
                if (parsed)
                {
                    num2 = value;
                }
                OnPropertyChange("Num2");
                OnPropertyChange("Result");
            }
        }
        public string Result
        {
            get
            {
                int result = int.Parse(Num1) + int.Parse(Num2);
                return result.ToString();
            }
            set
            {
                result = (int.Parse(Num1) + int.Parse(Num2)).ToString();
                OnPropertyChange("Result"); 
            }
        }


        private void OnPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
