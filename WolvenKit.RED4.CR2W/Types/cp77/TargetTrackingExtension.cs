using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetTrackingExtension : AITargetTrackerComponent
	{
		private DroppedThreatData _droppedThreatData;
		private CArray<CHandle<AICombatSquadScriptInterface>> _trackedCombatSquads;
		private CArray<CInt32> _trackedCombatSquadsCounters;
		private ThreatPersistanceMemory _threatPersistanceMemory;

		[Ordinal(4)] 
		[RED("droppedThreatData")] 
		public DroppedThreatData DroppedThreatData
		{
			get
			{
				if (_droppedThreatData == null)
				{
					_droppedThreatData = (DroppedThreatData) CR2WTypeManager.Create("DroppedThreatData", "droppedThreatData", cr2w, this);
				}
				return _droppedThreatData;
			}
			set
			{
				if (_droppedThreatData == value)
				{
					return;
				}
				_droppedThreatData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("trackedCombatSquads")] 
		public CArray<CHandle<AICombatSquadScriptInterface>> TrackedCombatSquads
		{
			get
			{
				if (_trackedCombatSquads == null)
				{
					_trackedCombatSquads = (CArray<CHandle<AICombatSquadScriptInterface>>) CR2WTypeManager.Create("array:handle:AICombatSquadScriptInterface", "trackedCombatSquads", cr2w, this);
				}
				return _trackedCombatSquads;
			}
			set
			{
				if (_trackedCombatSquads == value)
				{
					return;
				}
				_trackedCombatSquads = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("trackedCombatSquadsCounters")] 
		public CArray<CInt32> TrackedCombatSquadsCounters
		{
			get
			{
				if (_trackedCombatSquadsCounters == null)
				{
					_trackedCombatSquadsCounters = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "trackedCombatSquadsCounters", cr2w, this);
				}
				return _trackedCombatSquadsCounters;
			}
			set
			{
				if (_trackedCombatSquadsCounters == value)
				{
					return;
				}
				_trackedCombatSquadsCounters = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("threatPersistanceMemory")] 
		public ThreatPersistanceMemory ThreatPersistanceMemory
		{
			get
			{
				if (_threatPersistanceMemory == null)
				{
					_threatPersistanceMemory = (ThreatPersistanceMemory) CR2WTypeManager.Create("ThreatPersistanceMemory", "threatPersistanceMemory", cr2w, this);
				}
				return _threatPersistanceMemory;
			}
			set
			{
				if (_threatPersistanceMemory == value)
				{
					return;
				}
				_threatPersistanceMemory = value;
				PropertySet(this);
			}
		}

		public TargetTrackingExtension(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
