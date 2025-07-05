using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropdownItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		[Ordinal(1)] 
		[RED("labelKey")] 
		public CName LabelKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<DropdownItemDirection> Direction
		{
			get => GetPropertyValue<CEnum<DropdownItemDirection>>();
			set => SetPropertyValue<CEnum<DropdownItemDirection>>(value);
		}

		public DropdownItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
