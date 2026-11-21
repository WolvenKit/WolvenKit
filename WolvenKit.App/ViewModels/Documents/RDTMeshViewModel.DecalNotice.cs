using System.Threading.Tasks;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Decals are baked in the background, and until a bake is done the preview shows them
/// unbaked, which looks like a bug. While bakes run, the progress notice at the bottom of the
/// viewport (the one materials generation uses) says so: "Baking decals… 1 / 3".
/// Materials generation keeps the notice for itself while it runs. The decal notice shows only
/// when bakes take longer than <see cref="DecalNoticeDelayMs"/>, so quick ones don't flash it.
/// All of it runs on the UI thread.
/// </summary>
public partial class RDTMeshViewModel
{
    private const int DecalNoticeDelayMs = 300;

    private int _decalBakesStarted;
    private int _decalBakesDone;
    private bool _decalNoticeShown;
    private bool _decalNoticePending;
    private int _decalNoticeVersion;
    private bool _settingDecalNotice;

    private void OnDecalBakeStarted()
    {
        _decalBakesStarted++;
        UpdateDecalNotice();
    }

    private void OnDecalBakeFinished()
    {
        _decalBakesDone++;
        if (_decalBakesDone >= _decalBakesStarted)
        {
            _decalBakesStarted = 0;
            _decalBakesDone = 0;
        }

        UpdateDecalNotice();
    }

    private string? DecalNoticeText() =>
        _decalBakesStarted switch
        {
            0 => null,
            1 => "Baking decals…",
            _ => $"Baking decals… {_decalBakesDone} / {_decalBakesStarted}",
        };

    private void UpdateDecalNotice()
    {
        var text = DecalNoticeText();

        if (text == null || IsLoadingMaterials)
        {
            // Done, or materials generation shows its own progress: drop a pending notice
            _decalNoticeVersion++;
            _decalNoticePending = false;

            if (_decalNoticeShown)
            {
                _decalNoticeShown = false;
                if (!IsLoadingMaterials)
                {
                    SetDecalNotice(null);
                }
            }

            return;
        }

        if (_decalNoticeShown)
        {
            SetDecalNotice(text);
            return;
        }

        if (_decalNoticePending)
        {
            return;
        }

        _decalNoticePending = true;
        _ = ShowDecalNoticeLaterAsync(_decalNoticeVersion);
    }

    private async Task ShowDecalNoticeLaterAsync(int version)
    {
        await Task.Delay(DecalNoticeDelayMs);

        if (version != _decalNoticeVersion || _disposed)
        {
            return;
        }

        _decalNoticePending = false;

        if (DecalNoticeText() is string text && !IsLoadingMaterials)
        {
            _decalNoticeShown = true;
            SetDecalNotice(text);
        }
    }

    private void SetDecalNotice(string? text)
    {
        _settingDecalNotice = true;
        try
        {
            MaterialsProgressText = text;
            IsMaterialsProgressVisible = text != null;
        }
        finally
        {
            _settingDecalNotice = false;
        }
    }

    partial void OnIsMaterialsProgressVisibleChanged(bool value)
    {
        if (_settingDecalNotice)
        {
            return;
        }

        // Materials generation took the notice over, or gave it back: show the decals again
        // if bakes are still running
        _decalNoticeShown = false;
        if (!value)
        {
            UpdateDecalNotice();
        }
    }
}
