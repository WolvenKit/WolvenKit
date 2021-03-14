using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAgentSpawnedEvent : redEvent
	{
		private DeviceLink _spawnedAgent;
		private CEnum<gameEntitySpawnerEventType> _eventType;
		private CArray<CHandle<SecurityAreaControllerPS>> _securityAreas;

		[Ordinal(0)] 
		[RED("spawnedAgent")] 
		public DeviceLink SpawnedAgent
		{
			get
			{
				if (_spawnedAgent == null)
				{
					_spawnedAgent = (DeviceLink) CR2WTypeManager.Create("DeviceLink", "spawnedAgent", cr2w, this);
				}
				return _spawnedAgent;
			}
			set
			{
				if (_spawnedAgent == value)
				{
					return;
				}
				_spawnedAgent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<gameEntitySpawnerEventType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<gameEntitySpawnerEventType>) CR2WTypeManager.Create("gameEntitySpawnerEventType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("securityAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> SecurityAreas
		{
			get
			{
				if (_securityAreas == null)
				{
					_securityAreas = (CArray<CHandle<SecurityAreaControllerPS>>) CR2WTypeManager.Create("array:handle:SecurityAreaControllerPS", "securityAreas", cr2w, this);
				}
				return _securityAreas;
			}
			set
			{
				if (_securityAreas == value)
				{
					return;
				}
				_securityAreas = value;
				PropertySet(this);
			}
		}

		public SecurityAgentSpawnedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
