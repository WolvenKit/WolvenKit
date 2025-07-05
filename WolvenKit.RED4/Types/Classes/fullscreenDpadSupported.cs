using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class fullscreenDpadSupported : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("targetPath_DpadUp")] 
		public CWeakHandle<inkWidget> TargetPath_DpadUp
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("targetPath_DpadDown")] 
		public CWeakHandle<inkWidget> TargetPath_DpadDown
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("targetPath_DpadLeft")] 
		public CWeakHandle<inkWidget> TargetPath_DpadLeft
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("targetPath_DpadRight")] 
		public CWeakHandle<inkWidget> TargetPath_DpadRight
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public fullscreenDpadSupported()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
