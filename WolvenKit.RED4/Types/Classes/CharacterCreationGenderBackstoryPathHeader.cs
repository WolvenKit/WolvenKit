using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationGenderBackstoryPathHeader : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("selectedColor")] 
		public CColor SelectedColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("unSelectedColor")] 
		public CColor UnSelectedColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(6)] 
		[RED("textSelectedColor")] 
		public CColor TextSelectedColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(7)] 
		[RED("textUnselectedColor")] 
		public CColor TextUnselectedColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public CharacterCreationGenderBackstoryPathHeader()
		{
			Label = new inkTextWidgetReference();
			Desc = new inkTextWidgetReference();
			Bg = new inkWidgetReference();
			SelectedColor = new CColor();
			UnSelectedColor = new CColor();
			TextSelectedColor = new CColor();
			TextUnselectedColor = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
