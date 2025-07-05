using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkButtonDpadSupportedController : inkButtonAnimatedController
	{
		[Ordinal(25)] 
		[RED("targetPath_DpadUp")] 
		public CWeakHandle<inkWidget> TargetPath_DpadUp
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("targetPath_DpadDown")] 
		public CWeakHandle<inkWidget> TargetPath_DpadDown
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("targetPath_DpadLeft")] 
		public CWeakHandle<inkWidget> TargetPath_DpadLeft
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("targetPath_DpadRight")] 
		public CWeakHandle<inkWidget> TargetPath_DpadRight
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public inkButtonDpadSupportedController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
