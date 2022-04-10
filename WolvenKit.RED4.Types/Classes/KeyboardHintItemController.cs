using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KeyboardHintItemController : AHintItemController
	{
		[Ordinal(4)] 
		[RED("NumberText")] 
		public inkTextWidgetReference NumberText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("Frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("DisabledStateName")] 
		public CName DisabledStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("SelectedStateName")] 
		public CName SelectedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("FrameSelectedName")] 
		public CName FrameSelectedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("FrameUnselectedName")] 
		public CName FrameUnselectedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("AnimationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public KeyboardHintItemController()
		{
			Icon = new();
			UnavaliableText = new();
			NumberText = new();
			Frame = new();
			DisabledStateName = "Disabled";
			SelectedStateName = "Selected";
			FrameSelectedName = "top_button_selected";
			FrameUnselectedName = "top_button";
			AnimationName = "AnimRootOnThenOff";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
