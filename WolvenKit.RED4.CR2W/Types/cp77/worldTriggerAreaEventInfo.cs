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
			get => GetProperty(ref _nodeInstance);
			set => SetProperty(ref _nodeInstance, value);
		}

		[Ordinal(1)] 
		[RED("eventWorldPosition")] 
		public Vector3 EventWorldPosition
		{
			get => GetProperty(ref _eventWorldPosition);
			set => SetProperty(ref _eventWorldPosition, value);
		}

		[Ordinal(2)] 
		[RED("numActivatorsInArea")] 
		public CUInt32 NumActivatorsInArea
		{
			get => GetProperty(ref _numActivatorsInArea);
			set => SetProperty(ref _numActivatorsInArea, value);
		}

		[Ordinal(3)] 
		[RED("activatorID")] 
		public CUInt32 ActivatorID
		{
			get => GetProperty(ref _activatorID);
			set => SetProperty(ref _activatorID, value);
		}

		public worldTriggerAreaEventInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
