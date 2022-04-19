using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_NodeType : questICharacterManager_NodeType
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questICharacterManagerVisuals_NodeSubType> Subtype
		{
			get => GetPropertyValue<CHandle<questICharacterManagerVisuals_NodeSubType>>();
			set => SetPropertyValue<CHandle<questICharacterManagerVisuals_NodeSubType>>(value);
		}

		public questCharacterManagerVisuals_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
