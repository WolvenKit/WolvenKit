using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using WolvenKit.App.ViewModels;
using WolvenKit.UI.ViewModels;
using WolvenKit.UI.Views;

namespace WolvenKit.UI.Templates
{
    /*
     *  Experimental way to create and manage the data templates needed for the viewmodels.
     *  Credit to https://github.com/Joben28/SimpleWPF/blob/master/SimpleWPF/Core/DataTemplateManager.cs
     */

    public class ToolTemplateSelector : DataTemplateSelector
    {
        public ResourceDictionary Resources { get; private set; }

        public ToolTemplateSelector()
        {
            Resources = new ResourceDictionary();
            RegisterAll();
        }

        private void RegisterAll()
        {
            RegisterDataTemplate<ModExplorerViewModel, ModExplorerView>();
            //RegisterDataTemplate<LocalizedStringsViewModel, LocalizedStringsView>();
            //RegisterDataTemplate<ProjectExplorerViewModel, ProjectExplorerView>();
            //RegisterDataTemplate<AssetBrowserViewModel, AssetBrowserView>();
            //RegisterDataTemplate<GameConsoleViewModel, GameConsoleView>();
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if(Resources.Contains(item))
            {
                return Resources[item] as DataTemplate;
            }
            return null;
        }

        #region Creation
        private void RegisterDataTemplate<TViewModel, TView>()
            where TViewModel : IViewModel
            where TView : UserControl
        {
            var template = CreateTemplate<TViewModel, TView>();
            Resources.Add(template.DataTemplateKey, template);
        }

        private DataTemplate CreateTemplate<TViewModel, TView>()
            where TViewModel : IViewModel
            where TView : UserControl
        {
            return CreateTemplate(typeof(TViewModel), typeof(TView));
        }

        private DataTemplate CreateTemplate(Type viewModelType, Type viewType)
        {
            const string xamlTemplate = "<DataTemplate DataType=\"{{x:Type vm:{0}}}\"><v:{1} /></DataTemplate>";

            var context = new ParserContext
            {
                XamlTypeMapper = new XamlTypeMapper(Array.Empty<string>())
            };
            context.XamlTypeMapper.AddMappingProcessingInstruction("vm", viewModelType.Namespace, viewModelType.Assembly.FullName);
            context.XamlTypeMapper.AddMappingProcessingInstruction("v", viewType.Namespace, viewType.Assembly.FullName);

            context.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
            context.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
            context.XmlnsDictionary.Add("vm", "vm");
            context.XmlnsDictionary.Add("v", "v");

            var xaml = String.Format(xamlTemplate, viewModelType.Name, viewType.Name);

            var template = XamlReader.Parse(xaml, context) as DataTemplate;
            return template;
        }
        #endregion

    }
}
