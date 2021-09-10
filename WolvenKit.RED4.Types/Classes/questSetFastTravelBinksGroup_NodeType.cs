using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetFastTravelBinksGroup_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("selectedBinkDataGroup")] 
		public TweakDBID SelectedBinkDataGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
