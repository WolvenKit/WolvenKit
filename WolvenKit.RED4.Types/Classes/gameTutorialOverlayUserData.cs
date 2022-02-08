using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTutorialOverlayUserData : inkUserData
	{
		[Ordinal(0)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("overlayId")] 
		public CUInt32 OverlayId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
