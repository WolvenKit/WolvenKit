using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DiodeControlComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("affectedLights")] 
		public CArray<CName> AffectedLights
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("lightsState")] 
		public CBool LightsState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("primaryLightPreset")] 
		public DiodeLightPreset PrimaryLightPreset
		{
			get => GetPropertyValue<DiodeLightPreset>();
			set => SetPropertyValue<DiodeLightPreset>(value);
		}

		[Ordinal(8)] 
		[RED("secondaryLightPreset")] 
		public DiodeLightPreset SecondaryLightPreset
		{
			get => GetPropertyValue<DiodeLightPreset>();
			set => SetPropertyValue<DiodeLightPreset>(value);
		}

		[Ordinal(9)] 
		[RED("secondaryPresetActive")] 
		public CBool SecondaryPresetActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("secondaryPresetRemovalID")] 
		public gameDelayID SecondaryPresetRemovalID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public DiodeControlComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
