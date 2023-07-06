using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksPointsDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("desc1Text")] 
		public inkTextWidgetReference Desc1Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("value1Text")] 
		public inkTextWidgetReference Value1Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("icon1")] 
		public inkImageWidgetReference Icon1
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("desc2Text")] 
		public inkTextWidgetReference Desc2Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("value2Text")] 
		public inkTextWidgetReference Value2Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("icon2")] 
		public inkImageWidgetReference Icon2
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("screenType")] 
		public CEnum<CharacterScreenType> ScreenType
		{
			get => GetPropertyValue<CEnum<CharacterScreenType>>();
			set => SetPropertyValue<CEnum<CharacterScreenType>>(value);
		}

		public PerksPointsDisplayController()
		{
			Desc1Text = new inkTextWidgetReference();
			Value1Text = new inkTextWidgetReference();
			Icon1 = new inkImageWidgetReference();
			Desc2Text = new inkTextWidgetReference();
			Value2Text = new inkTextWidgetReference();
			Icon2 = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
