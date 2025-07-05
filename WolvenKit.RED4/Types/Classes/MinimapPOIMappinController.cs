using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("pingAnimationOnStateChange")] 
		public CBool PingAnimationOnStateChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("poiMappin")] 
		public CWeakHandle<gamemappinsPointOfInterestMappin> PoiMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsPointOfInterestMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsPointOfInterestMappin>>(value);
		}

		[Ordinal(17)] 
		[RED("questMappin")] 
		public CWeakHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>(value);
		}

		[Ordinal(18)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("mappinPhase")] 
		public CEnum<gamedataMappinPhase> MappinPhase
		{
			get => GetPropertyValue<CEnum<gamedataMappinPhase>>();
			set => SetPropertyValue<CEnum<gamedataMappinPhase>>(value);
		}

		[Ordinal(20)] 
		[RED("pingAnim")] 
		public CHandle<inkanimProxy> PingAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("mappinVariant")] 
		public CEnum<gamedataMappinVariant> MappinVariant
		{
			get => GetPropertyValue<CEnum<gamedataMappinVariant>>();
			set => SetPropertyValue<CEnum<gamedataMappinVariant>>(value);
		}

		[Ordinal(22)] 
		[RED("c_pingAnimCount")] 
		public CUInt32 C_pingAnimCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("isNcpdScanner")] 
		public CBool IsNcpdScanner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleMinimapMappinComponent")] 
		public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent
		{
			get => GetPropertyValue<CHandle<VehicleMinimapMappinComponent>>();
			set => SetPropertyValue<CHandle<VehicleMinimapMappinComponent>>(value);
		}

		[Ordinal(25)] 
		[RED("keepIconOnClamping")] 
		public CBool KeepIconOnClamping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MinimapPOIMappinController()
		{
			PulseWidget = new inkWidgetReference();
			C_pingAnimCount = 3;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
