using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetHUDEntryVisibility_NodeType : questIUIManagerNodeType
	{
		private CArray<CName> _hudEntryName;
		private CBool _usePreset;
		private TweakDBID _hudVisibilityPreset;
		private CBool _visibility;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CArray<CName> HudEntryName
		{
			get => GetProperty(ref _hudEntryName);
			set => SetProperty(ref _hudEntryName, value);
		}

		[Ordinal(1)] 
		[RED("usePreset")] 
		public CBool UsePreset
		{
			get => GetProperty(ref _usePreset);
			set => SetProperty(ref _usePreset, value);
		}

		[Ordinal(2)] 
		[RED("hudVisibilityPreset")] 
		public TweakDBID HudVisibilityPreset
		{
			get => GetProperty(ref _hudVisibilityPreset);
			set => SetProperty(ref _hudVisibilityPreset, value);
		}

		[Ordinal(3)] 
		[RED("visibility")] 
		public CBool Visibility
		{
			get => GetProperty(ref _visibility);
			set => SetProperty(ref _visibility, value);
		}
	}
}
