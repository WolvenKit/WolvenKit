using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class stealthAlertGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("indicator_01")] 
		public inkImageWidgetReference Indicator_01
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("indicator_02")] 
		public inkImageWidgetReference Indicator_02
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("indicator_03")] 
		public inkImageWidgetReference Indicator_03
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("fluff_01")] 
		public inkWidgetReference Fluff_01
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("fluff_02")] 
		public inkWidgetReference Fluff_02
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("fluff_03")] 
		public inkWidgetReference Fluff_03
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("fluff_04")] 
		public inkWidgetReference Fluff_04
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("playerBlackboardID")] 
		public CUInt32 PlayerBlackboardID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(21)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(23)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public stealthAlertGameController()
		{
			Label = new inkTextWidgetReference();
			Icon = new inkImageWidgetReference();
			Indicator_01 = new inkImageWidgetReference();
			Indicator_02 = new inkImageWidgetReference();
			Indicator_03 = new inkImageWidgetReference();
			Fluff_01 = new inkWidgetReference();
			Fluff_02 = new inkWidgetReference();
			Fluff_03 = new inkWidgetReference();
			Fluff_04 = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
