using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationNavigationBtn : inkButtonController
	{
		[Ordinal(13)] 
		[RED("icon1")] 
		public inkWidgetReference Icon1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("shouldPlaySoundOnHover")] 
		public CBool ShouldPlaySoundOnHover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public characterCreationNavigationBtn()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
