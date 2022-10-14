using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveUI;
using WolvenKit.Common.Model;

namespace WolvenKit.Interaction
{
    public static class Interactions
    {
        // wrappers
        public static async Task<WMessageBoxResult> ShowMessageBoxAsync(
            string text,
            string caption,
            WMessageBoxButtons messageBoxButtons = WMessageBoxButtons.OkCancel,
            WMessageBoxImage image = WMessageBoxImage.Question) =>
            await ShowConfirmation.Handle((text, caption, image, messageBoxButtons));



        // classic popups
        public static readonly Interaction<(string, string, WMessageBoxImage, WMessageBoxButtons), WMessageBoxResult> ShowConfirmation = new();

        public static readonly Interaction<IEnumerable<string>, bool> DeleteFiles = new();
        public static readonly Interaction<string, string> Rename = new();

        //custom views
        public static readonly Interaction<Unit, bool> ShowFirstTimeSetup = new();
        public static readonly Interaction<Unit, bool> ShowLaunchProfilesView = new();
        public static readonly Interaction<Unit, bool> ShowMaterialRepositoryView = new();

    }

    public enum WMessageBoxImage
    {
        None = 0,
        Hand = 1,
        Stop = 2,
        Error = 3,
        Question = 4,
        Exclamation = 5,
        Warning = 6,
        Asterisk = 7,
        Information = 8
    }

    public enum WMessageBoxButtons
    {
        Ok,
        OkCancel,
        Yes,
        YesNo,
        YesNoCancel,
        No
    }

    public enum WMessageBoxResult
    {
        None = 0,
        OK = 1,
        Cancel = 2,
        Yes = 3,
        No = 4,
        Custom = 5
    }
}
