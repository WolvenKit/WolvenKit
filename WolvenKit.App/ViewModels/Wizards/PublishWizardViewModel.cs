using ReactiveUI;
using WolvenKit.Functionality.Services;
using Splat;
using WolvenKit.Common;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Wizards
{
    public class PublishWizardViewModel : ReactiveObject
    {
        #region Properties

        #endregion Properties

        #region Methods

        /// <summary>
        /// Scoops up the packed files and packs it into a zip in a hierarchy that can be easily unzipped
        /// even if the user is not using our manager
        /// Package.wkp (zip)
        /// |---archive\pc\*.archive
        /// |
        /// |---wkpmeta\<modname>\<modname>.wkmeta (json) + icon
        /// |
        /// |---r6\cache\tweakdbpatches\<modname>.tweakdbpatch
        ///
        /// </summary>
        /// <param name="project">Project to pack</param>
        public void CyberpunkPublishStrategy(Cp77Project project) =>
            //TODO: I am not sure how to do this until we have packing

            Logger.Write("Packing Cyberpunk 2077 mod complete.", LogLevel.Info);

        public void PublishMod()
        {
            var proj = ServiceLocator.Default.ResolveType<IProjectManager>().ActiveProject as EditorProject;
            if (proj == null)
            {
                return;
            }

            Logger.Write("Starting mod publishing task... packing mod...", LogLevel.Info);
            ServiceLocator.Default.ResolveType<ICommandManager>().ExecuteCommand(AppCommands.Application.PackMod);
            Logger.Write("Packaging mod...", LogLevel.Info);
            switch (proj.GameType)
            {
                case GameType.Witcher3:
                    WitcherPublishStrategy(proj as Tw3Project);
                    break;

                case GameType.Cyberpunk2077:
                    CyberpunkPublishStrategy(proj as Cp77Project);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Scoops up the packed files and packs it into a zip in a hierarchy that can be easily unzipped
        /// even if the user is not using our manager
        /// Package.wkp (zip)
        /// |---archive\pc\*.archive
        /// |
        /// |---wkpmeta\<modname>\<modname>.wkmeta (json) + icon
        /// |
        /// |---r6\cache\tweakdbpatches\<modname>.tweakdbpatch
        ///
        /// </summary>
        /// <param name="project">Project to pack</param>
        public void WitcherPublishStrategy(Tw3Project project) =>
            //TODO: I am not sure how to do this until we have packing

            Logger.Write("Packing Witcher 3 mod complete.", LogLevel.Info);

        #endregion Methods
    }
}
