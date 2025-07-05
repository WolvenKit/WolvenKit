using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerAddDevelopmentPoint_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetPropertyValue<CEnum<gamedataDevelopmentPointType>>();
			set => SetPropertyValue<CEnum<gamedataDevelopmentPointType>>(value);
		}

		public questEntityManagerAddDevelopmentPoint_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
