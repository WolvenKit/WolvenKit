using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questContentTokenManager_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questIContentTokenManager_NodeSubType> Subtype
		{
			get => GetPropertyValue<CHandle<questIContentTokenManager_NodeSubType>>();
			set => SetPropertyValue<CHandle<questIContentTokenManager_NodeSubType>>(value);
		}

		public questContentTokenManager_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
