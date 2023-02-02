using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerSetAttachment_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questIEntityManagerSetAttachment_NodeSubType> Subtype
		{
			get => GetPropertyValue<CHandle<questIEntityManagerSetAttachment_NodeSubType>>();
			set => SetPropertyValue<CHandle<questIEntityManagerSetAttachment_NodeSubType>>(value);
		}

		public questEntityManagerSetAttachment_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
