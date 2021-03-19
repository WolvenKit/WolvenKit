using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DiodeControlComponent : gameScriptableComponent
	{
		private CArray<CName> _affectedLights;
		private CBool _lightsState;
		private DiodeLightPreset _primaryLightPreset;
		private DiodeLightPreset _secondaryLightPreset;
		private CBool _secondaryPresetActive;
		private gameDelayID _secondaryPresetRemovalID;

		[Ordinal(5)] 
		[RED("affectedLights")] 
		public CArray<CName> AffectedLights
		{
			get => GetProperty(ref _affectedLights);
			set => SetProperty(ref _affectedLights, value);
		}

		[Ordinal(6)] 
		[RED("lightsState")] 
		public CBool LightsState
		{
			get => GetProperty(ref _lightsState);
			set => SetProperty(ref _lightsState, value);
		}

		[Ordinal(7)] 
		[RED("primaryLightPreset")] 
		public DiodeLightPreset PrimaryLightPreset
		{
			get => GetProperty(ref _primaryLightPreset);
			set => SetProperty(ref _primaryLightPreset, value);
		}

		[Ordinal(8)] 
		[RED("secondaryLightPreset")] 
		public DiodeLightPreset SecondaryLightPreset
		{
			get => GetProperty(ref _secondaryLightPreset);
			set => SetProperty(ref _secondaryLightPreset, value);
		}

		[Ordinal(9)] 
		[RED("secondaryPresetActive")] 
		public CBool SecondaryPresetActive
		{
			get => GetProperty(ref _secondaryPresetActive);
			set => SetProperty(ref _secondaryPresetActive, value);
		}

		[Ordinal(10)] 
		[RED("secondaryPresetRemovalID")] 
		public gameDelayID SecondaryPresetRemovalID
		{
			get => GetProperty(ref _secondaryPresetRemovalID);
			set => SetProperty(ref _secondaryPresetRemovalID, value);
		}

		public DiodeControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
