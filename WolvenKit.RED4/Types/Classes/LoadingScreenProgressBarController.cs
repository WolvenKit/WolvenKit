using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadingScreenProgressBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("progressSpinerRoot")] 
		public inkWidgetReference ProgressSpinerRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rotationAnimationProxy")] 
		public CHandle<inkanimProxy> RotationAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(5)] 
		[RED("rotationAnimation")] 
		public CHandle<inkanimDefinition> RotationAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(6)] 
		[RED("rotationInterpolator")] 
		public CHandle<inkanimRotationInterpolator> RotationInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimRotationInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimRotationInterpolator>>(value);
		}

		public LoadingScreenProgressBarController()
		{
			ProgressBarRoot = new inkWidgetReference();
			ProgressBarFill = new inkWidgetReference();
			ProgressSpinerRoot = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
