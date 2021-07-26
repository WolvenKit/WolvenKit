using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using Catel.Services;
using WolvenKit.Common;

namespace WolvenKit.Functionality.ProjectManagement
{
    public static class ProjectHelpers
    {
        /// <summary>
        /// Locates a wolvenkit project and updates the recent items
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static async Task<string> LocateMissingProjectAsync(string parameter)
        {
            var recentlyUsedItemsService = ServiceLocator.Default.ResolveType<IRecentlyUsedItemsService>();
            var openFileService = ServiceLocator.Default.ResolveType<IOpenFileService>();
            var messageService = ServiceLocator.Default.ResolveType<IMessageService>();

            switch (await messageService.ShowAsync("The file doesn't seem to exist. Would you like to locate it? " +
                                                   "Select No to remove the project from your recent items.",
                    "File not found",
                    MessageButton.YesNoCancel))
            {
                // Try locating a project
                case MessageResult.OK:
                case MessageResult.Yes:
                {
                    var result = await openFileService.DetermineFileAsync(new DetermineOpenFileContext
                    {
                        FileName = Path.GetFileName(parameter),
                        Filter = "Cyberpunk 2077 Project | *.cpmodproj|Witcher 3 Project (*.w3modproj)|*.w3modproj",
                        IsMultiSelect = false,
                        Title = "Locate the WolvenKit project"
                    });

                    // if a file was found, update the recently used items with it
                    if (result.Result)
                    {
                        parameter = result.FileName;

                        var items = recentlyUsedItemsService.Items
                            .Where(_ => Path.GetFileName(_.Name) == Path.GetFileName(parameter))
                            .ToList();
                        if (items.Count > 0)
                        {
                            var item = items.First();
                            recentlyUsedItemsService.AddItem(new RecentlyUsedItem(parameter, item.DateTime));
                            recentlyUsedItemsService.RemoveItem(item);
                            return parameter;
                        }
                    }
                    // if canceled, do nothing
                    else
                    {
                        return "";
                    }

                    break;
                }
                // if you don't want to locate it, remove the item from the recently used projects
                case MessageResult.No:
                {
                    var items = recentlyUsedItemsService.Items
                        .Where(_ => _.Name == parameter)
                        .ToList();
                    if (items.Count > 0)
                    {
                        recentlyUsedItemsService.RemoveItem(items.FirstOrDefault());
                    }
                    return "";
                }
                // in case you cancel, do nothing
                case MessageResult.None:
                case MessageResult.Cancel:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return "";
        }



    }
}
