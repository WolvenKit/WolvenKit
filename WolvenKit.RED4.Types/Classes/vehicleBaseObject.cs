using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleBaseObject : gameObject
	{
		[Ordinal(40)] 
		[RED("archetype")] 
		public CResourceReference<AIArchetype> Archetype
		{
			get => GetPropertyValue<CResourceReference<AIArchetype>>();
			set => SetPropertyValue<CResourceReference<AIArchetype>>(value);
		}

		[Ordinal(41)] 
		[RED("vehicleComponent")] 
		public CWeakHandle<VehicleComponent> VehicleComponent
		{
			get => GetPropertyValue<CWeakHandle<VehicleComponent>>();
			set => SetPropertyValue<CWeakHandle<VehicleComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("uiComponent")] 
		public CWeakHandle<WorldWidgetComponent> UiComponent
		{
			get => GetPropertyValue<CWeakHandle<WorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<WorldWidgetComponent>>(value);
		}

		[Ordinal(43)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetPropertyValue<CHandle<CrowdMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<CrowdMemberBaseComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("hitTimestamp")] 
		public CFloat HitTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("drivingTrafficPattern")] 
		public CName DrivingTrafficPattern
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("onPavement")] 
		public CBool OnPavement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("timesSentReactionEvent")] 
		public CInt32 TimesSentReactionEvent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(49)] 
		[RED("vehicleUpsideDown")] 
		public CBool VehicleUpsideDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
