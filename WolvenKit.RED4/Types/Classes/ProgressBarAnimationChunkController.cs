using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgressBarAnimationChunkController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("rootCanvas")] 
		public inkWidgetReference RootCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("barCanvas")] 
		public inkWidgetReference BarCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hitAnim")] 
		public CHandle<inkanimProxy> HitAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(4)] 
		[RED("fullbarSize")] 
		public CFloat FullbarSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("isNegative")] 
		public CBool IsNegative
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProgressBarAnimationChunkController()
		{
			RootCanvas = new inkWidgetReference();
			BarCanvas = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
