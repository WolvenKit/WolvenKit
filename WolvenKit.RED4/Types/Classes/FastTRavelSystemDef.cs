using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTRavelSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("DestinationPoint")] 
		public gamebbScriptID_Variant DestinationPoint
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("StartingPoint")] 
		public gamebbScriptID_Variant StartingPoint
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("FastTravelStarted")] 
		public gamebbScriptID_Bool FastTravelStarted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("FastTravelLoadingScreenStarted")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenStarted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("FastTravelLoadingScreenFinished")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenFinished
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(5)] 
		[RED("LastSubwayGateUsed")] 
		public gamebbScriptID_EntityID LastSubwayGateUsed
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		public FastTRavelSystemDef()
		{
			DestinationPoint = new gamebbScriptID_Variant();
			StartingPoint = new gamebbScriptID_Variant();
			FastTravelStarted = new gamebbScriptID_Bool();
			FastTravelLoadingScreenStarted = new gamebbScriptID_Bool();
			FastTravelLoadingScreenFinished = new gamebbScriptID_Bool();
			LastSubwayGateUsed = new gamebbScriptID_EntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
