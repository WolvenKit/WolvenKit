using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeToggle : inkToggleController
	{
		[Ordinal(16)] 
		[RED("SelectedWidget")] 
		public inkWidgetReference SelectedWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("FrameWidget")] 
		public inkWidgetReference FrameWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("IconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("LabelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("photoModeGroupController")] 
		public CWeakHandle<PhotoModeTopBarController> PhotoModeGroupController
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeTopBarController>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeTopBarController>>(value);
		}

		[Ordinal(21)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("fade2Anim")] 
		public CHandle<inkanimProxy> Fade2Anim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PhotoModeToggle()
		{
			SelectedWidget = new inkWidgetReference();
			FrameWidget = new inkWidgetReference();
			IconWidget = new inkImageWidgetReference();
			LabelWidget = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
