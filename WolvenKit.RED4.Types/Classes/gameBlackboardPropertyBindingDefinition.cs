using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBlackboardPropertyBindingDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("serializableID")] 
		public gameBlackboardSerializableID SerializableID
		{
			get => GetPropertyValue<gameBlackboardSerializableID>();
			set => SetPropertyValue<gameBlackboardSerializableID>(value);
		}

		[Ordinal(1)] 
		[RED("propertyPath")] 
		public CArray<CName> PropertyPath
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("propertyType")] 
		public CName PropertyType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameBlackboardPropertyBindingDefinition()
		{
			SerializableID = new();
			PropertyPath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
