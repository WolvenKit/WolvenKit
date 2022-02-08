using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmokeMachine : BasicDistractionDevice
	{
		[Ordinal(103)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("entities")] 
		public CArray<CWeakHandle<entEntity>> Entities
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		public SmokeMachine()
		{
			ControllerTypeName = "SmokeMachineController";
			Entities = new();
		}
	}
}
