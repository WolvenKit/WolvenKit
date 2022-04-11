using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleScreenProjectionLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("widgetPos")] 
		public CWeakHandle<inkTextWidget> WidgetPos
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("worldPos")] 
		public CWeakHandle<inkTextWidget> WorldPos
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		public sampleScreenProjectionLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
