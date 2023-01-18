using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBlackboardSerializableID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blackboardName")] 
		public CName BlackboardName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("fieldName")] 
		public CName FieldName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameBlackboardSerializableID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
