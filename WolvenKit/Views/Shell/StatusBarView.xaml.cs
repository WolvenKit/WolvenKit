using System;
using Catel.IoC;
using CatFacts.Net;
using Orchestra.Services;

namespace WolvenKit.Views.Shell
{
    public partial class StatusBarView
    {
        #region Constructors

        public StatusBarView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        private async void Tag_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var client = new CatFactsClient();
            var randomFact = await client.GetRandomFactsAsync();
            try
            {
                Random x = new Random();
                var z = x.Next(0, randomFact.Length);
                ServiceLocator.Default.ResolveType<IGrowlNotificationService>().Info(randomFact[z].Text);

            }
            catch
            {

            }

        }
    }
}
