using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get => GetPropertyValue<CHandle<audioAmbientAreaSettings>>();
			set => SetPropertyValue<CHandle<audioAmbientAreaSettings>>(value);
		}

		[Ordinal(4)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("acousticRepositioningEnabled")] 
		public CBool AcousticRepositioningEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("overrideRolloff")] 
		public CBool OverrideRolloff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("rolloffOverride")] 
		public CFloat RolloffOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("useAutoOutdoorness")] 
		public CBool UseAutoOutdoorness
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioAmbientAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Default | Enums.TriggerChannel.TC_SoundAmbientArea;
			ObstructionChangeTime = 0.200000F;
			RolloffOverride = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
