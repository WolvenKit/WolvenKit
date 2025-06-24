#nullable enable
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Splat;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Converts RedBaseClass instances (node data) to ChunkViewModel for property editing
    /// </summary>
    public class RedTypeToChunkViewModelConverter : IValueConverter
    {
        private readonly ConditionalWeakTable<RedBaseClass, ChunkViewModel> _cache = new();
        
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not RedBaseClass redData)
                return null;

            // Use cache to avoid creating new ChunkViewModel on every selection change
            return _cache.GetValue(redData, CreateChunkViewModel);
        }

        private ChunkViewModel CreateChunkViewModel(RedBaseClass redData)
        {
            var factory = Locator.Current.GetService<IChunkViewmodelFactory>();
            var appViewModel = Locator.Current.GetService<AppViewModel>();
            
            if (factory == null || appViewModel == null)
                throw new InvalidOperationException("Required services not available");

            // Create a root-level ChunkViewModel for this node's data
            var typeName = redData.GetType().Name;
            var chunkViewModel = factory.ChunkViewModel(redData, typeName, appViewModel, null);
            
            // Force calculation of properties so they show up in the property editor
            chunkViewModel.CalculateProperties();
            
            return chunkViewModel;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException("RedTypeToChunkViewModelConverter is one-way only");
        }
    }
} 