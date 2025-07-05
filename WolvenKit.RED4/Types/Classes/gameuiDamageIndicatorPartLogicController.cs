using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDamageIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(3)] 
		[RED("maxDistanceForSharedIndicators")] 
		public CFloat MaxDistanceForSharedIndicators
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("arrowFrontWidget")] 
		public inkImageWidgetReference ArrowFrontWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("arrowBigWidget")] 
		public inkImageWidgetReference ArrowBigWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(9)] 
		[RED("damageTaken")] 
		public CFloat DamageTaken
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("continuous")] 
		public CBool Continuous
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("revengeActive")] 
		public CBool RevengeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiDamageIndicatorPartLogicController()
		{
			MaxDistanceForSharedIndicators = 4.000000F;
			ArrowFrontWidget = new inkImageWidgetReference();
			ArrowBigWidget = new inkImageWidgetReference();
			DamageThreshold = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
