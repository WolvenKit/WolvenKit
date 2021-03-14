using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneSystem : gameScriptableSystem
	{
		private CHandle<gameBlackboardSystem> _blackboardSystem;
		private wCHandle<gameIBlackboard> _blackboard;
		private questPhoneCallInformation _lastCallInformation;
		private CBool _contactsOpen;
		private CUInt32 _contactsOpenBBId;

		[Ordinal(0)] 
		[RED("BlackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get
			{
				if (_blackboardSystem == null)
				{
					_blackboardSystem = (CHandle<gameBlackboardSystem>) CR2WTypeManager.Create("handle:gameBlackboardSystem", "BlackboardSystem", cr2w, this);
				}
				return _blackboardSystem;
			}
			set
			{
				if (_blackboardSystem == value)
				{
					return;
				}
				_blackboardSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "Blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("LastCallInformation")] 
		public questPhoneCallInformation LastCallInformation
		{
			get
			{
				if (_lastCallInformation == null)
				{
					_lastCallInformation = (questPhoneCallInformation) CR2WTypeManager.Create("questPhoneCallInformation", "LastCallInformation", cr2w, this);
				}
				return _lastCallInformation;
			}
			set
			{
				if (_lastCallInformation == value)
				{
					return;
				}
				_lastCallInformation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ContactsOpen")] 
		public CBool ContactsOpen
		{
			get
			{
				if (_contactsOpen == null)
				{
					_contactsOpen = (CBool) CR2WTypeManager.Create("Bool", "ContactsOpen", cr2w, this);
				}
				return _contactsOpen;
			}
			set
			{
				if (_contactsOpen == value)
				{
					return;
				}
				_contactsOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ContactsOpenBBId")] 
		public CUInt32 ContactsOpenBBId
		{
			get
			{
				if (_contactsOpenBBId == null)
				{
					_contactsOpenBBId = (CUInt32) CR2WTypeManager.Create("Uint32", "ContactsOpenBBId", cr2w, this);
				}
				return _contactsOpenBBId;
			}
			set
			{
				if (_contactsOpenBBId == value)
				{
					return;
				}
				_contactsOpenBBId = value;
				PropertySet(this);
			}
		}

		public PhoneSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
