using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperations : DeviceOperations
	{
		private SGenericDeviceActionsData _stateActionsOverrides;
		private CArray<SBaseStateOperationData> _baseStateOperations;
		private CBool _wasStateCached;
		private CEnum<EDeviceStatus> _cachedState;

		[Ordinal(2)] 
		[RED("stateActionsOverrides")] 
		public SGenericDeviceActionsData StateActionsOverrides
		{
			get
			{
				if (_stateActionsOverrides == null)
				{
					_stateActionsOverrides = (SGenericDeviceActionsData) CR2WTypeManager.Create("SGenericDeviceActionsData", "stateActionsOverrides", cr2w, this);
				}
				return _stateActionsOverrides;
			}
			set
			{
				if (_stateActionsOverrides == value)
				{
					return;
				}
				_stateActionsOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("baseStateOperations")] 
		public CArray<SBaseStateOperationData> BaseStateOperations_
		{
			get
			{
				if (_baseStateOperations == null)
				{
					_baseStateOperations = (CArray<SBaseStateOperationData>) CR2WTypeManager.Create("array:SBaseStateOperationData", "baseStateOperations", cr2w, this);
				}
				return _baseStateOperations;
			}
			set
			{
				if (_baseStateOperations == value)
				{
					return;
				}
				_baseStateOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("cachedState")] 
		public CEnum<EDeviceStatus> CachedState
		{
			get
			{
				if (_cachedState == null)
				{
					_cachedState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "cachedState", cr2w, this);
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

		public BaseStateOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
