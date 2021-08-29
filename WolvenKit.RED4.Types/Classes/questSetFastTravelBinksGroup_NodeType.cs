using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetFastTravelBinksGroup_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _selectedBinkDataGroup;

		[Ordinal(0)] 
		[RED("selectedBinkDataGroup")] 
		public TweakDBID SelectedBinkDataGroup
		{
			get => GetProperty(ref _selectedBinkDataGroup);
			set => SetProperty(ref _selectedBinkDataGroup, value);
		}
	}
}
