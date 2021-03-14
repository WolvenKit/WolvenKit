using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		private CString _questEntryId;
		private CBool _canBeMerged;
		private CName _animation;
		private CString _sMSText;
		private CBool _dontRemoveOnRequest;
		private CInt32 _entryHash;
		private CInt32 _rewardSC;
		private CInt32 _rewardXP;
		private CEnum<EGenericNotificationPriority> _priority;

		[Ordinal(5)] 
		[RED("questEntryId")] 
		public CString QuestEntryId
		{
			get
			{
				if (_questEntryId == null)
				{
					_questEntryId = (CString) CR2WTypeManager.Create("String", "questEntryId", cr2w, this);
				}
				return _questEntryId;
			}
			set
			{
				if (_questEntryId == value)
				{
					return;
				}
				_questEntryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get
			{
				if (_canBeMerged == null)
				{
					_canBeMerged = (CBool) CR2WTypeManager.Create("Bool", "canBeMerged", cr2w, this);
				}
				return _canBeMerged;
			}
			set
			{
				if (_canBeMerged == value)
				{
					return;
				}
				_canBeMerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animation")] 
		public CName Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CName) CR2WTypeManager.Create("CName", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("SMSText")] 
		public CString SMSText
		{
			get
			{
				if (_sMSText == null)
				{
					_sMSText = (CString) CR2WTypeManager.Create("String", "SMSText", cr2w, this);
				}
				return _sMSText;
			}
			set
			{
				if (_sMSText == value)
				{
					return;
				}
				_sMSText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("dontRemoveOnRequest")] 
		public CBool DontRemoveOnRequest
		{
			get
			{
				if (_dontRemoveOnRequest == null)
				{
					_dontRemoveOnRequest = (CBool) CR2WTypeManager.Create("Bool", "dontRemoveOnRequest", cr2w, this);
				}
				return _dontRemoveOnRequest;
			}
			set
			{
				if (_dontRemoveOnRequest == value)
				{
					return;
				}
				_dontRemoveOnRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get
			{
				if (_entryHash == null)
				{
					_entryHash = (CInt32) CR2WTypeManager.Create("Int32", "entryHash", cr2w, this);
				}
				return _entryHash;
			}
			set
			{
				if (_entryHash == value)
				{
					return;
				}
				_entryHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rewardSC")] 
		public CInt32 RewardSC
		{
			get
			{
				if (_rewardSC == null)
				{
					_rewardSC = (CInt32) CR2WTypeManager.Create("Int32", "rewardSC", cr2w, this);
				}
				return _rewardSC;
			}
			set
			{
				if (_rewardSC == value)
				{
					return;
				}
				_rewardSC = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rewardXP")] 
		public CInt32 RewardXP
		{
			get
			{
				if (_rewardXP == null)
				{
					_rewardXP = (CInt32) CR2WTypeManager.Create("Int32", "rewardXP", cr2w, this);
				}
				return _rewardXP;
			}
			set
			{
				if (_rewardXP == value)
				{
					return;
				}
				_rewardXP = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("priority")] 
		public CEnum<EGenericNotificationPriority> Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CEnum<EGenericNotificationPriority>) CR2WTypeManager.Create("EGenericNotificationPriority", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		public gameuiQuestUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
