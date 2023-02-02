using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNarrationPlateComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("narrationCaption")] 
		public CName NarrationCaption
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("narrationText")] 
		public CName NarrationText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameNarrationPlateComponent()
		{
			Name = "Component";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
