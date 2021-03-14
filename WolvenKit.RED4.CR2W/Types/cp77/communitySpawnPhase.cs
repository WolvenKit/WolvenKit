using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySpawnPhase : ISerializable
	{
		private CName _phaseName;
		private CArray<CName> _appearances;
		private CArray<communityPhaseTimePeriod> _timePeriods;
		private CEnum<gameAlwaysSpawnedState> _alwaysSpawned;
		private CBool _prefetchAppearance;

		[Ordinal(0)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get
			{
				if (_phaseName == null)
				{
					_phaseName = (CName) CR2WTypeManager.Create("CName", "phaseName", cr2w, this);
				}
				return _phaseName;
			}
			set
			{
				if (_phaseName == value)
				{
					return;
				}
				_phaseName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CName>) CR2WTypeManager.Create("array:CName", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timePeriods")] 
		public CArray<communityPhaseTimePeriod> TimePeriods
		{
			get
			{
				if (_timePeriods == null)
				{
					_timePeriods = (CArray<communityPhaseTimePeriod>) CR2WTypeManager.Create("array:communityPhaseTimePeriod", "timePeriods", cr2w, this);
				}
				return _timePeriods;
			}
			set
			{
				if (_timePeriods == value)
				{
					return;
				}
				_timePeriods = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get
			{
				if (_alwaysSpawned == null)
				{
					_alwaysSpawned = (CEnum<gameAlwaysSpawnedState>) CR2WTypeManager.Create("gameAlwaysSpawnedState", "alwaysSpawned", cr2w, this);
				}
				return _alwaysSpawned;
			}
			set
			{
				if (_alwaysSpawned == value)
				{
					return;
				}
				_alwaysSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get
			{
				if (_prefetchAppearance == null)
				{
					_prefetchAppearance = (CBool) CR2WTypeManager.Create("Bool", "prefetchAppearance", cr2w, this);
				}
				return _prefetchAppearance;
			}
			set
			{
				if (_prefetchAppearance == value)
				{
					return;
				}
				_prefetchAppearance = value;
				PropertySet(this);
			}
		}

		public communitySpawnPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
