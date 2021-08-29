using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTutorialOverlayUserData : inkUserData
	{
		private CBool _hideOnInput;
		private CUInt32 _overlayId;

		[Ordinal(0)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetProperty(ref _hideOnInput);
			set => SetProperty(ref _hideOnInput, value);
		}

		[Ordinal(1)] 
		[RED("overlayId")] 
		public CUInt32 OverlayId
		{
			get => GetProperty(ref _overlayId);
			set => SetProperty(ref _overlayId, value);
		}
	}
}
