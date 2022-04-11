using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerCombat_NodeType : questICharacterManager_NodeType
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questICharacterManagerCombat_NodeSubType> Subtype
		{
			get => GetPropertyValue<CHandle<questICharacterManagerCombat_NodeSubType>>();
			set => SetPropertyValue<CHandle<questICharacterManagerCombat_NodeSubType>>(value);
		}
	}
}
