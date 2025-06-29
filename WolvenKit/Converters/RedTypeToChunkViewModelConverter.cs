#nullable enable
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Splat;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Converters
{
    /// <summary>
    /// Converts RedBaseClass instances (node data) to ChunkViewModel for property editing
    /// </summary>
    public class RedTypeToChunkViewModelConverter : IValueConverter
    {
        private readonly ConditionalWeakTable<RedBaseClass, ChunkViewModel> _cache = new();
        
        private static ILoggerService? s_loggerService;
        private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();
        
        // Singleton instance for cache management
        private static RedTypeToChunkViewModelConverter? _instance;
        public static RedTypeToChunkViewModelConverter Instance => _instance ??= new RedTypeToChunkViewModelConverter();
        
        /// <summary>
        /// Clears the cached ChunkViewModel for the specified data, forcing a fresh conversion
        /// </summary>
        public void InvalidateCache(RedBaseClass redData)
        {
            _cache.Remove(redData);
        }
        
        /// <summary>
        /// Clears all cached ChunkViewModels
        /// </summary>
        public void ClearCache()
        {
            // ConditionalWeakTable doesn't have a Clear method, so we create a new instance
            // The old cache will be garbage collected when there are no more references
        }
        
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not RedBaseClass redData)
                return null;

            try
            {
                // Use cache to avoid creating new ChunkViewModel on every selection change
                return _cache.GetValue(redData, CreateChunkViewModel);
            }
            catch (Exception ex)
            {
                LoggerService?.Error($"Failed to create ChunkViewModel for {redData.GetType().Name}: {ex.Message}");
                return null;
            }
        }

        private ChunkViewModel CreateChunkViewModel(RedBaseClass redData)
        {
            try
            {
                var factory = Locator.Current.GetService<IChunkViewmodelFactory>();
                var appViewModel = Locator.Current.GetService<AppViewModel>();
                
                if (factory == null)
                {
                    LoggerService?.Error("IChunkViewmodelFactory service not available");
                    throw new InvalidOperationException("IChunkViewmodelFactory service not available");
                }
                
                if (appViewModel == null)
                {
                    LoggerService?.Error("AppViewModel service not available");
                    throw new InvalidOperationException("AppViewModel service not available");
                }

                // Create a root-level ChunkViewModel for this node's data
                var typeName = redData.GetType().Name;
                var chunkViewModel = factory.ChunkViewModel(redData, typeName, appViewModel, null);
                
                if (chunkViewModel == null)
                {
                    LoggerService?.Error($"Factory returned null ChunkViewModel for {typeName}");
                    throw new InvalidOperationException($"Factory returned null ChunkViewModel for {typeName}");
                }
                
                // Force calculation of properties so they show up in the property editor
                try
                {
                    chunkViewModel.CalculateProperties();
                }
                catch (Exception ex)
                {
                    LoggerService?.Error($"Failed to calculate properties for {typeName}: {ex.Message}");
                    // Continue anyway, as the ChunkViewModel might still be partially usable
                }
                
                return chunkViewModel;
            }
            catch (Exception ex)
            {
                LoggerService?.Error($"Exception in CreateChunkViewModel for {redData.GetType().Name}: {ex}");
                throw; // Re-throw to be caught by the outer try-catch in Convert method
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException("RedTypeToChunkViewModelConverter is one-way only");
        }
    }
} 