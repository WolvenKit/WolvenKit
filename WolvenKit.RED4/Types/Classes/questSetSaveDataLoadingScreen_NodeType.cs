using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetSaveDataLoadingScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("selectedLoading")] 
		public TweakDBID SelectedLoading
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questSetSaveDataLoadingScreen_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
