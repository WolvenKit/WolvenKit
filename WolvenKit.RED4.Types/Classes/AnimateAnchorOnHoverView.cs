using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimateAnchorOnHoverView : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("Raycaster")] 
		public inkWidgetReference Raycaster
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(3)] 
		[RED("HoverAnchor")] 
		public Vector2 HoverAnchor
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("NormalAnchor")] 
		public Vector2 NormalAnchor
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("AnimTime")] 
		public CFloat AnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimateAnchorOnHoverView()
		{
			Raycaster = new();
			HoverAnchor = new();
			NormalAnchor = new();
			AnimTime = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
