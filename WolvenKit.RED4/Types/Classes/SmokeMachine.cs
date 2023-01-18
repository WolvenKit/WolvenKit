using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmokeMachine : BasicDistractionDevice
	{
		[Ordinal(100)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
