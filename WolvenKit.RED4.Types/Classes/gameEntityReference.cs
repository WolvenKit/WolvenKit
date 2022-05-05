using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntityReference : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameEntityReferenceType> Type
		{
			get => GetPropertyValue<CEnum<gameEntityReferenceType>>();
			set => SetPropertyValue<CEnum<gameEntityReferenceType>>(value);
		}

		[Ordinal(1)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("sceneActorContextName")] 
		public CName SceneActorContextName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("dynamicEntityUniqueName")] 
		public CName DynamicEntityUniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEntityReference()
		{
			Names = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
