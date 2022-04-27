using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTriggerAreaEventInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeInstance")] 
		public CHandle<worldTriggerAreaNodeInstance> NodeInstance
		{
			get => GetPropertyValue<CHandle<worldTriggerAreaNodeInstance>>();
			set => SetPropertyValue<CHandle<worldTriggerAreaNodeInstance>>(value);
		}

		[Ordinal(1)] 
		[RED("eventWorldPosition")] 
		public Vector3 EventWorldPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("numActivatorsInArea")] 
		public CUInt32 NumActivatorsInArea
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("activatorID")] 
		public CUInt32 ActivatorID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldTriggerAreaEventInfo()
		{
			EventWorldPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
