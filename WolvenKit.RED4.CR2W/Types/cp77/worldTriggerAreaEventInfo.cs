using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTriggerAreaEventInfo : CVariable
	{
		private CHandle<worldTriggerAreaNodeInstance> _nodeInstance;
		private Vector3 _eventWorldPosition;
		private CUInt32 _numActivatorsInArea;
		private CUInt32 _activatorID;

		[Ordinal(0)] 
		[RED("nodeInstance")] 
		public CHandle<worldTriggerAreaNodeInstance> NodeInstance
		{
			get
			{
				if (_nodeInstance == null)
				{
					_nodeInstance = (CHandle<worldTriggerAreaNodeInstance>) CR2WTypeManager.Create("handle:worldTriggerAreaNodeInstance", "nodeInstance", cr2w, this);
				}
				return _nodeInstance;
			}
			set
			{
				if (_nodeInstance == value)
				{
					return;
				}
				_nodeInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventWorldPosition")] 
		public Vector3 EventWorldPosition
		{
			get
			{
				if (_eventWorldPosition == null)
				{
					_eventWorldPosition = (Vector3) CR2WTypeManager.Create("Vector3", "eventWorldPosition", cr2w, this);
				}
				return _eventWorldPosition;
			}
			set
			{
				if (_eventWorldPosition == value)
				{
					return;
				}
				_eventWorldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numActivatorsInArea")] 
		public CUInt32 NumActivatorsInArea
		{
			get
			{
				if (_numActivatorsInArea == null)
				{
					_numActivatorsInArea = (CUInt32) CR2WTypeManager.Create("Uint32", "numActivatorsInArea", cr2w, this);
				}
				return _numActivatorsInArea;
			}
			set
			{
				if (_numActivatorsInArea == value)
				{
					return;
				}
				_numActivatorsInArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("activatorID")] 
		public CUInt32 ActivatorID
		{
			get
			{
				if (_activatorID == null)
				{
					_activatorID = (CUInt32) CR2WTypeManager.Create("Uint32", "activatorID", cr2w, this);
				}
				return _activatorID;
			}
			set
			{
				if (_activatorID == value)
				{
					return;
				}
				_activatorID = value;
				PropertySet(this);
			}
		}

		public worldTriggerAreaEventInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
