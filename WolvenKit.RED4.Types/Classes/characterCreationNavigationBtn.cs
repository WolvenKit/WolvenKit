using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationNavigationBtn : inkButtonController
	{
		[Ordinal(10)] 
		[RED("icon1")] 
		public inkWidgetReference Icon1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("shouldPlaySoundOnHover")] 
		public CBool ShouldPlaySoundOnHover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public characterCreationNavigationBtn()
		{
			Icon1 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
