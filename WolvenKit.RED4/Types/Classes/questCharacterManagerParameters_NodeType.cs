using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_NodeType : questICharacterManager_NodeType
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questICharacterManagerParameters_NodeSubType> Subtype
		{
			get => GetPropertyValue<CHandle<questICharacterManagerParameters_NodeSubType>>();
			set => SetPropertyValue<CHandle<questICharacterManagerParameters_NodeSubType>>(value);
		}

		public questCharacterManagerParameters_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
