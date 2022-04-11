using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetFastTravelBinksGroup_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("selectedBinkDataGroup")] 
		public TweakDBID SelectedBinkDataGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questSetFastTravelBinksGroup_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
