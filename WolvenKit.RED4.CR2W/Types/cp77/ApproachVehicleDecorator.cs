using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApproachVehicleDecorator : AIVehicleTaskAbstract
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _mountRequest;
		private CHandle<AIArgumentMapping> _entryPoint;
		private CBool _doorOpenRequestSent;
		private CBool _closeDoor;
		private CHandle<gameMountEventData> _mountEventData;
		private CHandle<gameMountEventData> _mountRequestData;
		private Vector4 _mountEntryPoint;
		private EngineTime _activationTime;
		private CBool _runCompanionCheck;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mountRequest")] 
		public CHandle<AIArgumentMapping> MountRequest
		{
			get
			{
				if (_mountRequest == null)
				{
					_mountRequest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountRequest", cr2w, this);
				}
				return _mountRequest;
			}
			set
			{
				if (_mountRequest == value)
				{
					return;
				}
				_mountRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryPoint")] 
		public CHandle<AIArgumentMapping> EntryPoint
		{
			get
			{
				if (_entryPoint == null)
				{
					_entryPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "entryPoint", cr2w, this);
				}
				return _entryPoint;
			}
			set
			{
				if (_entryPoint == value)
				{
					return;
				}
				_entryPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("doorOpenRequestSent")] 
		public CBool DoorOpenRequestSent
		{
			get
			{
				if (_doorOpenRequestSent == null)
				{
					_doorOpenRequestSent = (CBool) CR2WTypeManager.Create("Bool", "doorOpenRequestSent", cr2w, this);
				}
				return _doorOpenRequestSent;
			}
			set
			{
				if (_doorOpenRequestSent == value)
				{
					return;
				}
				_doorOpenRequestSent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("closeDoor")] 
		public CBool CloseDoor
		{
			get
			{
				if (_closeDoor == null)
				{
					_closeDoor = (CBool) CR2WTypeManager.Create("Bool", "closeDoor", cr2w, this);
				}
				return _closeDoor;
			}
			set
			{
				if (_closeDoor == value)
				{
					return;
				}
				_closeDoor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mountEventData")] 
		public CHandle<gameMountEventData> MountEventData
		{
			get
			{
				if (_mountEventData == null)
				{
					_mountEventData = (CHandle<gameMountEventData>) CR2WTypeManager.Create("handle:gameMountEventData", "mountEventData", cr2w, this);
				}
				return _mountEventData;
			}
			set
			{
				if (_mountEventData == value)
				{
					return;
				}
				_mountEventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("mountRequestData")] 
		public CHandle<gameMountEventData> MountRequestData
		{
			get
			{
				if (_mountRequestData == null)
				{
					_mountRequestData = (CHandle<gameMountEventData>) CR2WTypeManager.Create("handle:gameMountEventData", "mountRequestData", cr2w, this);
				}
				return _mountRequestData;
			}
			set
			{
				if (_mountRequestData == value)
				{
					return;
				}
				_mountRequestData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mountEntryPoint")] 
		public Vector4 MountEntryPoint
		{
			get
			{
				if (_mountEntryPoint == null)
				{
					_mountEntryPoint = (Vector4) CR2WTypeManager.Create("Vector4", "mountEntryPoint", cr2w, this);
				}
				return _mountEntryPoint;
			}
			set
			{
				if (_mountEntryPoint == value)
				{
					return;
				}
				_mountEntryPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("activationTime")] 
		public EngineTime ActivationTime
		{
			get
			{
				if (_activationTime == null)
				{
					_activationTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "activationTime", cr2w, this);
				}
				return _activationTime;
			}
			set
			{
				if (_activationTime == value)
				{
					return;
				}
				_activationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("runCompanionCheck")] 
		public CBool RunCompanionCheck
		{
			get
			{
				if (_runCompanionCheck == null)
				{
					_runCompanionCheck = (CBool) CR2WTypeManager.Create("Bool", "runCompanionCheck", cr2w, this);
				}
				return _runCompanionCheck;
			}
			set
			{
				if (_runCompanionCheck == value)
				{
					return;
				}
				_runCompanionCheck = value;
				PropertySet(this);
			}
		}

		public ApproachVehicleDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
