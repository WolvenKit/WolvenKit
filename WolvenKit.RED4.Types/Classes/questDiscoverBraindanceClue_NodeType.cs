using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDiscoverBraindanceClue_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questDiscoverBraindanceClue_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
