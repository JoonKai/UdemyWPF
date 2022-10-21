using System.Collections.ObjectModel;
using System.Windows;

namespace DataBindingPractice
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<int> availableNumbers { get; set; }



        public MainWindow()
        {
            
            availableNumbers = new ObservableCollection<int>();
            int counter = 0;
            for(int i = 0; i < 10; i++)
            {
                availableNumbers.Add(counter++);
            }
            InitializeComponent();
            //this.DataContext = this;
        }

        private void AddNumber(object sender, RoutedEventArgs e)
        {
            availableNumbers.Add(1);
        }

        private void DeleteNumber(object sender, RoutedEventArgs e)
        {
            availableNumbers.RemoveAt(0);
        }
    }
}
