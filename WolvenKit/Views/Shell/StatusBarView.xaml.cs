using System;

using CatFacts.Net;
using ReactiveUI;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Shell
{
    public partial class StatusBarView : ReactiveUserControl<StatusBarViewModel>
    {
        #region Constructors

        public StatusBarView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<StatusBarViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {

            });

        }

        #endregion Constructors

        //private async void Tag_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    try
        //    {
        //        var client = new CatFactsClient();
        //        var randomFact = await client.GetRandomFactsAsync(Locator.Current.GetService<ISettingsManager>().CatFactAnimal.ToString().ToLower());
        //        Random x = new Random();
        //        var z = x.Next(0, randomFact.Length);
        //        var catfact = randomFact[z].Text;

        //        if (GetWords(catfact).Count > 1)
        //        {
        //            if (!catfact.Contains("test", StringComparison.OrdinalIgnoreCase))
        //            {
        //                Locator.Current.GetService<INotificationService>().Info(catfact);
        //            }
        //        }
        //        else
        //        {
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        public System.Collections.Generic.List<string> GetWords(string Input)
        {
            string[] Result = System.Text.RegularExpressions.Regex.Split(Input, @"\b");

            System.Collections.Generic.List<string> Words = new System.Collections.Generic.List<string>();

            foreach (string s in Result)

            {
                if (System.Text.RegularExpressions.Regex.IsMatch(s, @"[a-z]+", System.Text.RegularExpressions.RegexOptions.IgnoreCase))

                {
                    Words.Add(s);
                }
            }

            return Words;
        }
    }
}
