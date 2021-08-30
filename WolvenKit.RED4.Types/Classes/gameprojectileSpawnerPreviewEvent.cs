using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSpawnerPreviewEvent : redEvent
	{
		private CBool _previewActive;

		[Ordinal(0)] 
		[RED("previewActive")] 
		public CBool PreviewActive
		{
			get => GetProperty(ref _previewActive);
			set => SetProperty(ref _previewActive, value);
		}

		public gameprojectileSpawnerPreviewEvent()
		{
			_previewActive = true;
		}
	}
}
