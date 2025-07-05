using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationGenderSelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] 
		[RED("streetRat_male")] 
		public inkWidgetReference StreetRat_male
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("streetRat_female")] 
		public inkWidgetReference StreetRat_female
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("clickTarget")] 
		public inkWidgetReference ClickTarget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("maleAnimProxy")] 
		public CHandle<inkanimProxy> MaleAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("femaleAnimProxy")] 
		public CHandle<inkanimProxy> FemaleAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CharacterCreationGenderSelectionMenu()
		{
			StreetRat_male = new inkWidgetReference();
			StreetRat_female = new inkWidgetReference();
			ClickTarget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
