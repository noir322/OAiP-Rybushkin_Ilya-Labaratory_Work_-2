// N2.1 - 12
//XAML
Window x:Class="lab_6.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:lab_6"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        <StackPanel Grid.Row="0" Grid.Column="0">
            <TextBlock Text="f(x) = x * x + 4 * x + 5" Height="144" TextWrapping="NoWrap" LineHeight="30" TextAlignment="Justify"/>
        </StackPanel>
        <StackPanel Grid.Row="1" Grid.Column="0">
            <TextBlock Text="f(x) = 1/x * x + 4 * x + 5 " Height="144" TextWrapping="NoWrap" LineHeight="30" TextAlignment="Justify"/>
        </StackPanel>
        <StackPanel Grid.Row="2" Grid.Column="0">
            <TextBlock Text="при x меньше либо равен 2"/>
        </StackPanel>
        <StackPanel Grid.Row="0" Grid.Column="2">
            <TextBox Name="value" Text="{Binding UserInput,UpdateSourceTrigger=PropertyChanged}" Margin="4"/>
        </StackPanel>
        <StackPanel Grid.Row="0" Grid.Column="1">
            <Button Content="Решение 1-го случая" Click="Button_Click"/>
        </StackPanel>
        <StackPanel Grid.Row="1" Grid.Column="1">
            <Button Content="Решение 2 - го случая" Click="Button_Click_1"/>
        </StackPanel>
        <StackPanel Grid.Row="1" Grid.Column="2">
            <TextBox Name = "second_solution" Text="{Binding UserInput,UpdateSourceTrigger=PropertyChanged}" Margin="4"/>
        </StackPanel>
    </Grid>
</Window>

//C#
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

namespace lab_6
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(value.Text);
            int i;
            i = x * x + 4 * x + 5;
            string stri = Convert.ToString(i);
            MessageBox.Show(stri);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(second_solution.Text);
            int b;
            b = a * a + 4 * a + 5;
            string strb = Convert.ToString(b);
            MessageBox.Show($" 1\r\n---\r\n{strb}");
        }
    }
}

//N2.2 - 15
