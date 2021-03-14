using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCKillDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<EDownedType> _eventType;
		private DamageHistoryEntry _damageEntry;
		private CBool _isDownedRecorded;

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<EDownedType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<EDownedType>) CR2WTypeManager.Create("EDownedType", "eventType", cr2w, this);
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
		[RED("damageEntry")] 
		public DamageHistoryEntry DamageEntry
		{
			get
			{
				if (_damageEntry == null)
				{
					_damageEntry = (DamageHistoryEntry) CR2WTypeManager.Create("DamageHistoryEntry", "damageEntry", cr2w, this);
				}
				return _damageEntry;
			}
			set
			{
				if (_damageEntry == value)
				{
					return;
				}
				_damageEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isDownedRecorded")] 
		public CBool IsDownedRecorded
		{
			get
			{
				if (_isDownedRecorded == null)
				{
					_isDownedRecorded = (CBool) CR2WTypeManager.Create("Bool", "isDownedRecorded", cr2w, this);
				}
				return _isDownedRecorded;
			}
			set
			{
				if (_isDownedRecorded == value)
				{
					return;
				}
				_isDownedRecorded = value;
				PropertySet(this);
			}
		}

		public NPCKillDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
