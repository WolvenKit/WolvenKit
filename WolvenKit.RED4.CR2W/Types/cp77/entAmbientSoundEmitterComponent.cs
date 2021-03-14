using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAmbientSoundEmitterComponent : entIPlacedComponent
	{
		private CHandle<audioAmbientAreaSettings> _settings;
		private CBool _usePhysicsObstruction;
		private CBool _occlusionEnabled;
		private CBool _repositionEnabled;
		private CFloat _obstructionChangeTime;

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("repositionEnabled")] 
		public CBool RepositionEnabled
		{
			get
			{
				if (_repositionEnabled == null)
				{
					_repositionEnabled = (CBool) CR2WTypeManager.Create("Bool", "repositionEnabled", cr2w, this);
				}
				return _repositionEnabled;
			}
			set
			{
				if (_repositionEnabled == value)
				{
					return;
				}
				_repositionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		public entAmbientSoundEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
