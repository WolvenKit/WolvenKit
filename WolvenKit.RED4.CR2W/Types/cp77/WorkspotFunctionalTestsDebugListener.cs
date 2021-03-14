using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotFunctionalTestsDebugListener : IScriptable
	{
		private entEntityID _entityId;
		private CInt32 _instancesCreated;
		private CInt32 _instancesRemoved;
		private CInt32 _workspotsSetup;
		private CInt32 _workspotsStarted;
		private CInt32 _workspotsFinished;
		private CArray<CString> _animationsStack;
		private CArray<CString> _animationsSkippedStack;
		private CArray<CString> _animationsMissingStack;
		private CInt32 _skipOverflows;
		private CInt32 _teleportRequests;
		private CInt32 _movementRequests;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get
			{
				if (_entityId == null)
				{
					_entityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityId", cr2w, this);
				}
				return _entityId;
			}
			set
			{
				if (_entityId == value)
				{
					return;
				}
				_entityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instancesCreated")] 
		public CInt32 InstancesCreated
		{
			get
			{
				if (_instancesCreated == null)
				{
					_instancesCreated = (CInt32) CR2WTypeManager.Create("Int32", "instancesCreated", cr2w, this);
				}
				return _instancesCreated;
			}
			set
			{
				if (_instancesCreated == value)
				{
					return;
				}
				_instancesCreated = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instancesRemoved")] 
		public CInt32 InstancesRemoved
		{
			get
			{
				if (_instancesRemoved == null)
				{
					_instancesRemoved = (CInt32) CR2WTypeManager.Create("Int32", "instancesRemoved", cr2w, this);
				}
				return _instancesRemoved;
			}
			set
			{
				if (_instancesRemoved == value)
				{
					return;
				}
				_instancesRemoved = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("workspotsSetup")] 
		public CInt32 WorkspotsSetup
		{
			get
			{
				if (_workspotsSetup == null)
				{
					_workspotsSetup = (CInt32) CR2WTypeManager.Create("Int32", "workspotsSetup", cr2w, this);
				}
				return _workspotsSetup;
			}
			set
			{
				if (_workspotsSetup == value)
				{
					return;
				}
				_workspotsSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("workspotsStarted")] 
		public CInt32 WorkspotsStarted
		{
			get
			{
				if (_workspotsStarted == null)
				{
					_workspotsStarted = (CInt32) CR2WTypeManager.Create("Int32", "workspotsStarted", cr2w, this);
				}
				return _workspotsStarted;
			}
			set
			{
				if (_workspotsStarted == value)
				{
					return;
				}
				_workspotsStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("workspotsFinished")] 
		public CInt32 WorkspotsFinished
		{
			get
			{
				if (_workspotsFinished == null)
				{
					_workspotsFinished = (CInt32) CR2WTypeManager.Create("Int32", "workspotsFinished", cr2w, this);
				}
				return _workspotsFinished;
			}
			set
			{
				if (_workspotsFinished == value)
				{
					return;
				}
				_workspotsFinished = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animationsStack")] 
		public CArray<CString> AnimationsStack
		{
			get
			{
				if (_animationsStack == null)
				{
					_animationsStack = (CArray<CString>) CR2WTypeManager.Create("array:String", "animationsStack", cr2w, this);
				}
				return _animationsStack;
			}
			set
			{
				if (_animationsStack == value)
				{
					return;
				}
				_animationsStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animationsSkippedStack")] 
		public CArray<CString> AnimationsSkippedStack
		{
			get
			{
				if (_animationsSkippedStack == null)
				{
					_animationsSkippedStack = (CArray<CString>) CR2WTypeManager.Create("array:String", "animationsSkippedStack", cr2w, this);
				}
				return _animationsSkippedStack;
			}
			set
			{
				if (_animationsSkippedStack == value)
				{
					return;
				}
				_animationsSkippedStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animationsMissingStack")] 
		public CArray<CString> AnimationsMissingStack
		{
			get
			{
				if (_animationsMissingStack == null)
				{
					_animationsMissingStack = (CArray<CString>) CR2WTypeManager.Create("array:String", "animationsMissingStack", cr2w, this);
				}
				return _animationsMissingStack;
			}
			set
			{
				if (_animationsMissingStack == value)
				{
					return;
				}
				_animationsMissingStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("skipOverflows")] 
		public CInt32 SkipOverflows
		{
			get
			{
				if (_skipOverflows == null)
				{
					_skipOverflows = (CInt32) CR2WTypeManager.Create("Int32", "skipOverflows", cr2w, this);
				}
				return _skipOverflows;
			}
			set
			{
				if (_skipOverflows == value)
				{
					return;
				}
				_skipOverflows = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("teleportRequests")] 
		public CInt32 TeleportRequests
		{
			get
			{
				if (_teleportRequests == null)
				{
					_teleportRequests = (CInt32) CR2WTypeManager.Create("Int32", "teleportRequests", cr2w, this);
				}
				return _teleportRequests;
			}
			set
			{
				if (_teleportRequests == value)
				{
					return;
				}
				_teleportRequests = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("movementRequests")] 
		public CInt32 MovementRequests
		{
			get
			{
				if (_movementRequests == null)
				{
					_movementRequests = (CInt32) CR2WTypeManager.Create("Int32", "movementRequests", cr2w, this);
				}
				return _movementRequests;
			}
			set
			{
				if (_movementRequests == value)
				{
					return;
				}
				_movementRequests = value;
				PropertySet(this);
			}
		}

		public WorkspotFunctionalTestsDebugListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
