
using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.UserControls.ProductGroupList;
using ACME.Frontend.WPF.UserControls.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ACME.Frontend.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(MainViewModel model, IUnitOfWork iou)
    {
        InitializeComponent();
        DataContext = model;
        //model.CurrentView = new ProductGroupListView(new ProductGroupListViewModel(iou));
    }

}
