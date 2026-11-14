using System;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Detail logging of the preview (per-material bake steps, shader layers, sector load
/// timings): off by default, so it does not fill the log view. Set the environment variable
/// WOLVENKIT_PREVIEW_TRACE=1 before starting WolvenKit to get it for a test.
/// </summary>
public partial class RDTMeshViewModel
{
    private static readonly bool s_previewTrace =
        Environment.GetEnvironmentVariable("WOLVENKIT_PREVIEW_TRACE") is "1" or "true";

    private void PreviewTrace(string message)
    {
        if (s_previewTrace)
        {
            _loggerService.Debug(message);
        }
    }
}
