using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleColorInkController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("vehiclePS")] 
		public CWeakHandle<VehicleComponentPS> VehiclePS
		{
			get => GetPropertyValue<CWeakHandle<VehicleComponentPS>>();
			set => SetPropertyValue<CWeakHandle<VehicleComponentPS>>(value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("GlitchAnimProxy")] 
		public CHandle<inkanimProxy> GlitchAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("SpoilerAnimProxy")] 
		public CHandle<inkanimProxy> SpoilerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("vvcComponent")] 
		public CWeakHandle<vehicleVisualCustomizationComponent> VvcComponent
		{
			get => GetPropertyValue<CWeakHandle<vehicleVisualCustomizationComponent>>();
			set => SetPropertyValue<CWeakHandle<vehicleVisualCustomizationComponent>>(value);
		}

		[Ordinal(17)] 
		[RED("primaryColorPane")] 
		public inkWidgetReference PrimaryColorPane
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("secondaryColorPane")] 
		public inkWidgetReference SecondaryColorPane
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("primaryColor")] 
		public CArray<inkImageWidgetReference> PrimaryColor
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(20)] 
		[RED("secondaryColor")] 
		public CArray<inkImageWidgetReference> SecondaryColor
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(21)] 
		[RED("carPartType")] 
		public CEnum<VehicleVisualCustomizationWidgetCarPart> CarPartType
		{
			get => GetPropertyValue<CEnum<VehicleVisualCustomizationWidgetCarPart>>();
			set => SetPropertyValue<CEnum<VehicleVisualCustomizationWidgetCarPart>>(value);
		}

		[Ordinal(22)] 
		[RED("colorModDefinition")] 
		public CHandle<redCallbackObject> ColorModDefinition
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("cachedPrimaryColor")] 
		public CColor CachedPrimaryColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(24)] 
		[RED("cachedSecondaryColor")] 
		public CColor CachedSecondaryColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(25)] 
		[RED("colorSecondaryCodeListener")] 
		public CHandle<redCallbackObject> ColorSecondaryCodeListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("vehicleCollisionListener")] 
		public CHandle<redCallbackObject> VehicleCollisionListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("vehicleDamageListener")] 
		public CHandle<redCallbackObject> VehicleDamageListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("vehicleModBlockedByDamageListener")] 
		public CHandle<redCallbackObject> VehicleModBlockedByDamageListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("vehicleModActiveListener")] 
		public CHandle<redCallbackObject> VehicleModActiveListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("vehicleTPPCallbackID")] 
		public CHandle<redCallbackObject> VehicleTPPCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("vehicleSpeedListener")] 
		public CHandle<redCallbackObject> VehicleSpeedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("cachedColorDefinitions")] 
		public vehicleVisualModdingDefinition CachedColorDefinitions
		{
			get => GetPropertyValue<vehicleVisualModdingDefinition>();
			set => SetPropertyValue<vehicleVisualModdingDefinition>(value);
		}

		[Ordinal(33)] 
		[RED("moddingBlockedByDamage")] 
		public CBool ModdingBlockedByDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("visualCustomizationActive")] 
		public CBool VisualCustomizationActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("spoilerDeployed")] 
		public CBool SpoilerDeployed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("cachedTppView")] 
		public CBool CachedTppView
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(38)] 
		[RED("damageAnimLoopProxy")] 
		public CHandle<inkanimProxy> DamageAnimLoopProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public vehicleColorInkController()
		{
			PrimaryColorPane = new inkWidgetReference();
			SecondaryColorPane = new inkWidgetReference();
			PrimaryColor = new();
			SecondaryColor = new();
			CachedPrimaryColor = new CColor();
			CachedSecondaryColor = new CColor();
			CachedColorDefinitions = new vehicleVisualModdingDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
