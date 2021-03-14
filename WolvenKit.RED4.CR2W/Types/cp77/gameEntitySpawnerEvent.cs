using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerEvent : redEvent
	{
		private entEntityID _spawnedEntityId;
		private CEnum<gameEntitySpawnerEventType> _eventType;

		[Ordinal(0)] 
		[RED("spawnedEntityId")] 
		public entEntityID SpawnedEntityId
		{
			get
			{
				if (_spawnedEntityId == null)
				{
					_spawnedEntityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "spawnedEntityId", cr2w, this);
				}
				return _spawnedEntityId;
			}
			set
			{
				if (_spawnedEntityId == value)
				{
					return;
				}
				_spawnedEntityId = value;
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

		public gameEntitySpawnerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
