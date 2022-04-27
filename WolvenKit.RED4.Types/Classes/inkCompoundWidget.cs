using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCompoundWidget : inkWidget
	{
		[Ordinal(20)] 
		[RED("childOrder")] 
		public CEnum<inkEChildOrder> ChildOrder
		{
			get => GetPropertyValue<CEnum<inkEChildOrder>>();
			set => SetPropertyValue<CEnum<inkEChildOrder>>(value);
		}

		[Ordinal(21)] 
		[RED("children")] 
		public CHandle<inkMultiChildren> Children
		{
			get => GetPropertyValue<CHandle<inkMultiChildren>>();
			set => SetPropertyValue<CHandle<inkMultiChildren>>(value);
		}

		[Ordinal(22)] 
		[RED("childMargin")] 
		public inkMargin ChildMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public inkCompoundWidget()
		{
			ChildMargin = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
