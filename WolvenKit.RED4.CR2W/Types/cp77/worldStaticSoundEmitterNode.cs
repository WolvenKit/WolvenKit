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
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("audioName")] 
		public CName AudioName
		{
			get
			{
				if (_audioName == null)
				{
					_audioName = (CName) CR2WTypeManager.Create("CName", "audioName", cr2w, this);
				}
				return _audioName;
			}
			set
			{
				if (_audioName == value)
				{
					return;
				}
				_audioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (CHandle<audioAmbientAreaSettings>) CR2WTypeManager.Create("handle:audioAmbientAreaSettings", "Settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get
			{
				if (_usePhysicsObstruction == null)
				{
					_usePhysicsObstruction = (CBool) CR2WTypeManager.Create("Bool", "usePhysicsObstruction", cr2w, this);
				}
				return _usePhysicsObstruction;
			}
			set
			{
				if (_usePhysicsObstruction == value)
				{
					return;
				}
				_usePhysicsObstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get
			{
				if (_occlusionEnabled == null)
				{
					_occlusionEnabled = (CBool) CR2WTypeManager.Create("Bool", "occlusionEnabled", cr2w, this);
				}
				return _occlusionEnabled;
			}
			set
			{
				if (_occlusionEnabled == value)
				{
					return;
				}
				_occlusionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("acousticRepositioningEnabled")] 
		public CBool AcousticRepositioningEnabled
		{
			get
			{
				if (_acousticRepositioningEnabled == null)
				{
					_acousticRepositioningEnabled = (CBool) CR2WTypeManager.Create("Bool", "acousticRepositioningEnabled", cr2w, this);
				}
				return _acousticRepositioningEnabled;
			}
			set
			{
				if (_acousticRepositioningEnabled == value)
				{
					return;
				}
				_acousticRepositioningEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get
			{
				if (_obstructionChangeTime == null)
				{
					_obstructionChangeTime = (CFloat) CR2WTypeManager.Create("Float", "obstructionChangeTime", cr2w, this);
				}
				return _obstructionChangeTime;
			}
			set
			{
				if (_obstructionChangeTime == value)
				{
					return;
				}
				_obstructionChangeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useDoppler")] 
		public CBool UseDoppler
		{
			get
			{
				if (_useDoppler == null)
				{
					_useDoppler = (CBool) CR2WTypeManager.Create("Bool", "useDoppler", cr2w, this);
				}
				return _useDoppler;
			}
			set
			{
				if (_useDoppler == value)
				{
					return;
				}
				_useDoppler = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dopplerFactor")] 
		public CFloat DopplerFactor
		{
			get
			{
				if (_dopplerFactor == null)
				{
					_dopplerFactor = (CFloat) CR2WTypeManager.Create("Float", "dopplerFactor", cr2w, this);
				}
				return _dopplerFactor;
			}
			set
			{
				if (_dopplerFactor == value)
				{
					return;
				}
				_dopplerFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("setOpenDoorEmitter")] 
		public CBool SetOpenDoorEmitter
		{
			get
			{
				if (_setOpenDoorEmitter == null)
				{
					_setOpenDoorEmitter = (CBool) CR2WTypeManager.Create("Bool", "setOpenDoorEmitter", cr2w, this);
				}
				return _setOpenDoorEmitter;
			}
			set
			{
				if (_setOpenDoorEmitter == value)
				{
					return;
				}
				_setOpenDoorEmitter = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get
			{
				if (_emitterMetadataName == null)
				{
					_emitterMetadataName = (CName) CR2WTypeManager.Create("CName", "emitterMetadataName", cr2w, this);
				}
				return _emitterMetadataName;
			}
			set
			{
				if (_emitterMetadataName == value)
				{
					return;
				}
				_emitterMetadataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("overrideRolloff")] 
		public CBool OverrideRolloff
		{
			get
			{
				if (_overrideRolloff == null)
				{
					_overrideRolloff = (CBool) CR2WTypeManager.Create("Bool", "overrideRolloff", cr2w, this);
				}
				return _overrideRolloff;
			}
			set
			{
				if (_overrideRolloff == value)
				{
					return;
				}
				_overrideRolloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("rolloffOverride")] 
		public CFloat RolloffOverride
		{
			get
			{
				if (_rolloffOverride == null)
				{
					_rolloffOverride = (CFloat) CR2WTypeManager.Create("Float", "rolloffOverride", cr2w, this);
				}
				return _rolloffOverride;
			}
			set
			{
				if (_rolloffOverride == value)
				{
					return;
				}
				_rolloffOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ambientPaletteTag")] 
		public CName AmbientPaletteTag
		{
			get
			{
				if (_ambientPaletteTag == null)
				{
					_ambientPaletteTag = (CName) CR2WTypeManager.Create("CName", "ambientPaletteTag", cr2w, this);
				}
				return _ambientPaletteTag;
			}
			set
			{
				if (_ambientPaletteTag == value)
				{
					return;
				}
				_ambientPaletteTag = value;
				PropertySet(this);
			}
		}

		public worldStaticSoundEmitterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
