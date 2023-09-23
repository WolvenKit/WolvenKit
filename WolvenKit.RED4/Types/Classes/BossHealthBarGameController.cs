using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BossHealthBarGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("healthControllerRef")] 
		public inkWidgetReference HealthControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("healthPercentage")] 
		public inkTextWidgetReference HealthPercentage
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("bossName")] 
		public inkTextWidgetReference BossName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("dividerContainerRef")] 
		public inkCompoundWidgetReference DividerContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("statListener")] 
		public CHandle<BossHealthStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<BossHealthStatListener>>();
			set => SetPropertyValue<CHandle<BossHealthStatListener>>(value);
		}

		[Ordinal(14)] 
		[RED("boss")] 
		public CWeakHandle<NPCPuppet> Boss
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(15)] 
		[RED("healthController")] 
		public CWeakHandle<NameplateBarLogicController> HealthController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(16)] 
		[RED("thresholds")] 
		public CArray<CFloat> Thresholds
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("unfoldAnimation")] 
		public CHandle<inkanimProxy> UnfoldAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("foldAnimation")] 
		public CHandle<inkanimProxy> FoldAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("bossPuppets")] 
		public CArray<CWeakHandle<NPCPuppet>> BossPuppets
		{
			get => GetPropertyValue<CArray<CWeakHandle<NPCPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NPCPuppet>>>(value);
		}

		public BossHealthBarGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
