using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAmbientAreaNotifier : worldITriggerAreaNotifer
	{
		private CHandle<audioAmbientAreaSettings> _settings;
		private CBool _usePhysicsObstruction;
		private CBool _occlusionEnabled;
		private CBool _acousticRepositioningEnabled;
		private CFloat _obstructionChangeTime;
		private CBool _overrideRolloff;
		private CFloat _rolloffOverride;
		private CBool _useAutoOutdoorness;

		[Ordinal(3)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(4)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get => GetProperty(ref _usePhysicsObstruction);
			set => SetProperty(ref _usePhysicsObstruction, value);
		}

		[Ordinal(5)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetProperty(ref _occlusionEnabled);
			set => SetProperty(ref _occlusionEnabled, value);
		}

		[Ordinal(6)] 
		[RED("acousticRepositioningEnabled")] 
		public CBool AcousticRepositioningEnabled
		{
			get => GetProperty(ref _acousticRepositioningEnabled);
			set => SetProperty(ref _acousticRepositioningEnabled, value);
		}

		[Ordinal(7)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetProperty(ref _obstructionChangeTime);
			set => SetProperty(ref _obstructionChangeTime, value);
		}

		[Ordinal(8)] 
		[RED("overrideRolloff")] 
		public CBool OverrideRolloff
		{
			get => GetProperty(ref _overrideRolloff);
			set => SetProperty(ref _overrideRolloff, value);
		}

		[Ordinal(9)] 
		[RED("rolloffOverride")] 
		public CFloat RolloffOverride
		{
			get => GetProperty(ref _rolloffOverride);
			set => SetProperty(ref _rolloffOverride, value);
		}

		[Ordinal(10)] 
		[RED("useAutoOutdoorness")] 
		public CBool UseAutoOutdoorness
		{
			get => GetProperty(ref _useAutoOutdoorness);
			set => SetProperty(ref _useAutoOutdoorness, value);
		}
	}
}
