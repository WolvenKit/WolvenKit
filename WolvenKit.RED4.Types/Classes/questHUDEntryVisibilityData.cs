using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHUDEntryVisibilityData : RedBaseClass
	{
		private CName _hudEntryName;
		private CEnum<worlduiEntryVisibility> _visibility;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetProperty(ref _hudEntryName);
			set => SetProperty(ref _hudEntryName, value);
		}

		[Ordinal(1)] 
		[RED("visibility")] 
		public CEnum<worlduiEntryVisibility> Visibility
		{
			get => GetProperty(ref _visibility);
			set => SetProperty(ref _visibility, value);
		}
	}
}
