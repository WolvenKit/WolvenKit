using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperations : DeviceOperations
	{
		private CArray<SDoorStateOperationData> _doorStateOperations;
		private CBool _wasStateCached;
		private CEnum<EDoorStatus> _cachedState;

		[Ordinal(2)] 
		[RED("doorStateOperations")] 
		public CArray<SDoorStateOperationData> DoorStateOperations_
		{
			get
			{
				if (_doorStateOperations == null)
				{
					_doorStateOperations = (CArray<SDoorStateOperationData>) CR2WTypeManager.Create("array:SDoorStateOperationData", "doorStateOperations", cr2w, this);
				}
				return _doorStateOperations;
			}
			set
			{
				if (_doorStateOperations == value)
				{
					return;
				}
				_doorStateOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get
			{
				if (_wasStateCached == null)
				{
					_wasStateCached = (CBool) CR2WTypeManager.Create("Bool", "wasStateCached", cr2w, this);
				}
				return _wasStateCached;
			}
			set
			{
				if (_wasStateCached == value)
				{
					return;
				}
				_wasStateCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("cachedState")] 
		public CEnum<EDoorStatus> CachedState
		{
			get
			{
				if (_cachedState == null)
				{
					_cachedState = (CEnum<EDoorStatus>) CR2WTypeManager.Create("EDoorStatus", "cachedState", cr2w, this);
				}
				return _cachedState;
			}
			set
			{
				if (_cachedState == value)
				{
					return;
				}
				_cachedState = value;
				PropertySet(this);
			}
		}

		public DoorStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
