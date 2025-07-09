using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Services
{
    /// <summary>
    /// Service to handle cache invalidation for RedTypeToChunkViewModelCollectionConverter
    /// </summary>
    public interface IConverterCacheService
    {
        /// <summary>
        /// Invalidates the converter cache for the specified RedBaseClass
        /// </summary>
        /// <param name="redData">The data object to invalidate from cache</param>
        void InvalidateConverterCache(RedBaseClass redData);
    }
    
    public class ConverterCacheService : IConverterCacheService
    {
        private static ILoggerService? s_loggerService;
        private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();
        
        public void InvalidateConverterCache(RedBaseClass redData)
        {
            try
            {
                // Find the converter resource in the application
                var app = Application.Current;
                if (app?.Resources["RedTypeToChunkViewModelCollectionConverter"] is object converter)
                {
                    // Use reflection to access the static cache and remove the entry
                    var converterType = converter.GetType();
                    var cacheField = converterType.GetField("s_globalCache", BindingFlags.Static | BindingFlags.NonPublic);
                    
                    if (cacheField?.GetValue(null) is ConditionalWeakTable<RedBaseClass, List<ChunkViewModel>> cache)
                    {
                        cache.Remove(redData);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerService?.Error($"Error invalidating converter cache: {ex.Message}");
            }
        }
    }
} 