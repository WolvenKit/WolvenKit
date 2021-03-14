using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaControllerPS : MasterControllerPS
	{
		private CHandle<SecuritySystemControllerPS> _system;
		private CArray<AreaEntry> _usersInPerimeter;
		private CBool _isPlayerInside;
		private CEnum<ESecurityAccessLevel> _securityAccessLevel;
		private CEnum<ESecurityAreaType> _securityAreaType;
		private EventsFilters _eventsFilters;
		private CArray<AreaTypeTransition> _areaTransitions;
		private CBool _pendingDisableRequest;
		private OutputPersistentData _lastOutput;
		private CBool _questPlayerHasTriggeredCombat;
		private CBool _hasThisAreaReceivedCombatNotification;
		private CBool _pendingNotifyPlayerAboutTransition;

		[Ordinal(104)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get
			{
				if (_system == null)
				{
					_system = (CHandle<SecuritySystemControllerPS>) CR2WTypeManager.Create("handle:SecuritySystemControllerPS", "system", cr2w, this);
				}
				return _system;
			}
			set
			{
				if (_system == value)
				{
					return;
				}
				_system = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("usersInPerimeter")] 
		public CArray<AreaEntry> UsersInPerimeter
		{
			get
			{
				if (_usersInPerimeter == null)
				{
					_usersInPerimeter = (CArray<AreaEntry>) CR2WTypeManager.Create("array:AreaEntry", "usersInPerimeter", cr2w, this);
				}
				return _usersInPerimeter;
			}
			set
			{
				if (_usersInPerimeter == value)
				{
					return;
				}
				_usersInPerimeter = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isPlayerInside")] 
		public CBool IsPlayerInside
		{
			get
			{
				if (_isPlayerInside == null)
				{
					_isPlayerInside = (CBool) CR2WTypeManager.Create("Bool", "isPlayerInside", cr2w, this);
				}
				return _isPlayerInside;
			}
			set
			{
				if (_isPlayerInside == value)
				{
					return;
				}
				_isPlayerInside = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("securityAccessLevel")] 
		public CEnum<ESecurityAccessLevel> SecurityAccessLevel
		{
			get
			{
				if (_securityAccessLevel == null)
				{
					_securityAccessLevel = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "securityAccessLevel", cr2w, this);
				}
				return _securityAccessLevel;
			}
			set
			{
				if (_securityAccessLevel == value)
				{
					return;
				}
				_securityAccessLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get
			{
				if (_securityAreaType == null)
				{
					_securityAreaType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "securityAreaType", cr2w, this);
				}
				return _securityAreaType;
			}
			set
			{
				if (_securityAreaType == value)
				{
					return;
				}
				_securityAreaType = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("eventsFilters")] 
		public EventsFilters EventsFilters
		{
			get
			{
				if (_eventsFilters == null)
				{
					_eventsFilters = (EventsFilters) CR2WTypeManager.Create("EventsFilters", "eventsFilters", cr2w, this);
				}
				return _eventsFilters;
			}
			set
			{
				if (_eventsFilters == value)
				{
					return;
				}
				_eventsFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("areaTransitions")] 
		public CArray<AreaTypeTransition> AreaTransitions
		{
			get
			{
				if (_areaTransitions == null)
				{
					_areaTransitions = (CArray<AreaTypeTransition>) CR2WTypeManager.Create("array:AreaTypeTransition", "areaTransitions", cr2w, this);
				}
				return _areaTransitions;
			}
			set
			{
				if (_areaTransitions == value)
				{
					return;
				}
				_areaTransitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("pendingDisableRequest")] 
		public CBool PendingDisableRequest
		{
			get
			{
				if (_pendingDisableRequest == null)
				{
					_pendingDisableRequest = (CBool) CR2WTypeManager.Create("Bool", "pendingDisableRequest", cr2w, this);
				}
				return _pendingDisableRequest;
			}
			set
			{
				if (_pendingDisableRequest == value)
				{
					return;
				}
				_pendingDisableRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("lastOutput")] 
		public OutputPersistentData LastOutput
		{
			get
			{
				if (_lastOutput == null)
				{
					_lastOutput = (OutputPersistentData) CR2WTypeManager.Create("OutputPersistentData", "lastOutput", cr2w, this);
				}
				return _lastOutput;
			}
			set
			{
				if (_lastOutput == value)
				{
					return;
				}
				_lastOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("questPlayerHasTriggeredCombat")] 
		public CBool QuestPlayerHasTriggeredCombat
		{
			get
			{
				if (_questPlayerHasTriggeredCombat == null)
				{
					_questPlayerHasTriggeredCombat = (CBool) CR2WTypeManager.Create("Bool", "questPlayerHasTriggeredCombat", cr2w, this);
				}
				return _questPlayerHasTriggeredCombat;
			}
			set
			{
				if (_questPlayerHasTriggeredCombat == value)
				{
					return;
				}
				_questPlayerHasTriggeredCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("hasThisAreaReceivedCombatNotification")] 
		public CBool HasThisAreaReceivedCombatNotification
		{
			get
			{
				if (_hasThisAreaReceivedCombatNotification == null)
				{
					_hasThisAreaReceivedCombatNotification = (CBool) CR2WTypeManager.Create("Bool", "hasThisAreaReceivedCombatNotification", cr2w, this);
				}
				return _hasThisAreaReceivedCombatNotification;
			}
			set
			{
				if (_hasThisAreaReceivedCombatNotification == value)
				{
					return;
				}
				_hasThisAreaReceivedCombatNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("pendingNotifyPlayerAboutTransition")] 
		public CBool PendingNotifyPlayerAboutTransition
		{
			get
			{
				if (_pendingNotifyPlayerAboutTransition == null)
				{
					_pendingNotifyPlayerAboutTransition = (CBool) CR2WTypeManager.Create("Bool", "pendingNotifyPlayerAboutTransition", cr2w, this);
				}
				return _pendingNotifyPlayerAboutTransition;
			}
			set
			{
				if (_pendingNotifyPlayerAboutTransition == value)
				{
					return;
				}
				_pendingNotifyPlayerAboutTransition = value;
				PropertySet(this);
			}
		}

		public SecurityAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
