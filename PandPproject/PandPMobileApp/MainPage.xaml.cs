using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using PandPMobileApp.PandPNameSpace;
using System.Collections.ObjectModel;

namespace PandPMobileApp
{
    public partial class MainPage : PhoneApplicationPage
    {
       PandPNameSpace.PandPDomainServicesoapClient proxy = new PandPNameSpace.PandPDomainServicesoapClient();
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        void proxy_GetMembersCompleted(object sender, GetMembersCompletedEventArgs e)
        {
            MessageBox.Show("tu sam");
            ObservableCollection<Members> members = e.Result.RootResults;
            membersListBox.ItemsSource = members;

        }

        public void getMembers()
        {
            try
            {
                proxy.GetMembersCompleted += new EventHandler<GetMembersCompletedEventArgs>(proxy_GetMembersCompleted);
                proxy.GetTrafficCompleted += new EventHandler<GetTrafficCompletedEventArgs>(proxy_GetTrafficCompleted);
                proxy.GetTrafficAsync();
         
                MessageBox.Show("Sinkronizacija u tijeku....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void proxy_GetTrafficCompleted(object sender, GetTrafficCompletedEventArgs e)
        {
            if (e.Result.RootResults == null) MessageBox.Show("nesto je u kurcu");
            else MessageBox.Show("ipak nije");
       
            //membersListBox.ItemsSource = members;
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            getMembers();
        }
    }
}