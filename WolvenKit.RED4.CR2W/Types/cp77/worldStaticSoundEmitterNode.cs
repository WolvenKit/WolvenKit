using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticSoundEmitterNode : worldNode
	{
		private CFloat _radius;
		private CName _audioName;
		private CHandle<audioAmbientAreaSettings> _settings;
		private CBool _usePhysicsObstruction;
		private CBool _occlusionEnabled;
		private CBool _acousticRepositioningEnabled;
		private CFloat _obstructionChangeTime;
		private CBool _useDoppler;
		private CFloat _dopplerFactor;
		private CBool _setOpenDoorEmitter;
		private CName _emitterMetadataName;
		private CBool _overrideRolloff;
		private CFloat _rolloffOverride;
		private CName _ambientPaletteTag;

		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(5)] 
		[RED("audioName")] 
		public CName AudioName
		{
			get => GetProperty(ref _audioName);
			set => SetProperty(ref _audioName, value);
		}

		[Ordinal(6)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(7)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get => GetProperty(ref _usePhysicsObstruction);
			set => SetProperty(ref _usePhysicsObstruction, value);
		}

		[Ordinal(8)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetProperty(ref _occlusionEnabled);
			set => SetProperty(ref _occlusionEnabled, value);
		}

		[Ordinal(9)] 
		[RED("acousticRepositioningEnabled")] 
		public CBool AcousticRepositioningEnabled
		{
			get => GetProperty(ref _acousticRepositioningEnabled);
			set => SetProperty(ref _acousticRepositioningEnabled, value);
		}

		[Ordinal(10)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetProperty(ref _obstructionChangeTime);
			set => SetProperty(ref _obstructionChangeTime, value);
		}

		[Ordinal(11)] 
		[RED("useDoppler")] 
		public CBool UseDoppler
		{
			get => GetProperty(ref _useDoppler);
			set => SetProperty(ref _useDoppler, value);
		}

		[Ordinal(12)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get => GetProperty(ref _dopplerFactor);
			set => SetProperty(ref _dopplerFactor, value);
		}

		[Ordinal(13)] 
		[RED("setOpenDoorEmitter")] 
		public CBool SetOpenDoorEmitter
		{
			get => GetProperty(ref _setOpenDoorEmitter);
			set => SetProperty(ref _setOpenDoorEmitter, value);
		}

		[Ordinal(14)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get => GetProperty(ref _emitterMetadataName);
			set => SetProperty(ref _emitterMetadataName, value);
		}

		[Ordinal(15)] 
		[RED("overrideRolloff")] 
		public CBool OverrideRolloff
		{
			get => GetProperty(ref _overrideRolloff);
			set => SetProperty(ref _overrideRolloff, value);
		}

		[Ordinal(16)] 
		[RED("rolloffOverride")] 
		public CFloat RolloffOverride
		{
			get => GetProperty(ref _rolloffOverride);
			set => SetProperty(ref _rolloffOverride, value);
		}

		[Ordinal(17)] 
		[RED("ambientPaletteTag")] 
		public CName AmbientPaletteTag
		{
			get => GetProperty(ref _ambientPaletteTag);
			set => SetProperty(ref _ambientPaletteTag, value);
		}

		public worldStaticSoundEmitterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
