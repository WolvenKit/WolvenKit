using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkNavigationOverrideEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("from")] 
		public inkWidgetReference From
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<inkDiscreteNavigationDirection> Direction
		{
			get => GetPropertyValue<CEnum<inkDiscreteNavigationDirection>>();
			set => SetPropertyValue<CEnum<inkDiscreteNavigationDirection>>(value);
		}

		[Ordinal(2)] 
		[RED("to")] 
		public inkWidgetReference To
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public inkNavigationOverrideEntry()
		{
			From = new();
			To = new();
		}
	}
}
