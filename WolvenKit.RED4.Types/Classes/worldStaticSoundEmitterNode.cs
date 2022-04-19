using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticSoundEmitterNode : worldNode
	{
		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("audioName")] 
		public CName AudioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get => GetPropertyValue<CHandle<audioAmbientAreaSettings>>();
			set => SetPropertyValue<CHandle<audioAmbientAreaSettings>>(value);
		}

		[Ordinal(7)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("acousticRepositioningEnabled")] 
		public CBool AcousticRepositioningEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("useDoppler")] 
		public CBool UseDoppler
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("setOpenDoorEmitter")] 
		public CBool SetOpenDoorEmitter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("overrideRolloff")] 
		public CBool OverrideRolloff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("rolloffOverride")] 
		public CFloat RolloffOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("ambientPaletteTag")] 
		public CName AmbientPaletteTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldStaticSoundEmitterNode()
		{
			ObstructionChangeTime = 0.200000F;
			DopplerFactor = 1.000000F;
			RolloffOverride = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
