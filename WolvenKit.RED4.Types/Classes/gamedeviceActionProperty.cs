using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedeviceActionProperty : IScriptable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("typeName")] 
		public CName TypeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("first")] 
		public CVariant First
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		[Ordinal(3)] 
		[RED("second")] 
		public CVariant Second
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		[Ordinal(4)] 
		[RED("third")] 
		public CVariant Third
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CEnum<gamedeviceActionPropertyFlags> Flags
		{
			get => GetPropertyValue<CEnum<gamedeviceActionPropertyFlags>>();
			set => SetPropertyValue<CEnum<gamedeviceActionPropertyFlags>>(value);
		}

		public gamedeviceActionProperty()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
