using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatHUDManager : gameScriptableComponent
	{
		private CBool _isRunning;
		private CArray<CombatTarget> _targets;
		private CFloat _interval;
		private CFloat _timeSinceLastUpdate;

		[Ordinal(5)] 
		[RED("isRunning")] 
		public CBool IsRunning
		{
			get
			{
				if (_isRunning == null)
				{
					_isRunning = (CBool) CR2WTypeManager.Create("Bool", "isRunning", cr2w, this);
				}
				return _isRunning;
			}
			set
			{
				if (_isRunning == value)
				{
					return;
				}
				_isRunning = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targets")] 
		public CArray<CombatTarget> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<CombatTarget>) CR2WTypeManager.Create("array:CombatTarget", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get
			{
				if (_interval == null)
				{
					_interval = (CFloat) CR2WTypeManager.Create("Float", "interval", cr2w, this);
				}
				return _interval;
			}
			set
			{
				if (_interval == value)
				{
					return;
				}
				_interval = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("timeSinceLastUpdate")] 
		public CFloat TimeSinceLastUpdate
		{
			get
			{
				if (_timeSinceLastUpdate == null)
				{
					_timeSinceLastUpdate = (CFloat) CR2WTypeManager.Create("Float", "timeSinceLastUpdate", cr2w, this);
				}
				return _timeSinceLastUpdate;
			}
			set
			{
				if (_timeSinceLastUpdate == value)
				{
					return;
				}
				_timeSinceLastUpdate = value;
				PropertySet(this);
			}
		}

		public CombatHUDManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
