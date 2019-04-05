using System.Windows;
using System.Windows.Controls;
using WPFNetwork;


namespace WPFLDEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        public class variable
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Comment { get; set; }

        }

        public void Networkbutton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            EditorLD.Items.Add(item);
#pragma warning disable CS0436 // Тип конфликтует с импортированным типом
            NetworkControl item1 = new NetworkControl();
#pragma warning restore CS0436 // Тип конфликтует с импортированным типом
            EditorLD.Items.Add(item1);

        }

        public void NewContact_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
#pragma warning disable CS0436 // Тип конфликтует с импортированным типом
            Contact item1 = new Contact();
#pragma warning restore CS0436 // Тип конфликтует с импортированным типом
            EditorLD.Items.Add(item);
            EditorLD.Items.Add(item1);

        }
    }
}
