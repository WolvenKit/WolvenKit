using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactTextStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("locKeyList")] 
		public CArray<CName> LocKeyList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public FactTextStruct()
		{
			LocKeyList = new();
			Description = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
