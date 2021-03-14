using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaNotifier : worldITriggerAreaNotifer
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("useAutoOutdoorness")] 
		public CBool UseAutoOutdoorness
		{
			get
			{
				if (_useAutoOutdoorness == null)
				{
					_useAutoOutdoorness = (CBool) CR2WTypeManager.Create("Bool", "useAutoOutdoorness", cr2w, this);
				}
				return _useAutoOutdoorness;
			}
			set
			{
				if (_useAutoOutdoorness == value)
				{
					return;
				}
				_useAutoOutdoorness = value;
				PropertySet(this);
			}
		}

		public audioAmbientAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
