using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTriggerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("triggerID")] 
		public entEntityID TriggerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public entEntityGameInterface Activator
		{
			get => GetPropertyValue<entEntityGameInterface>();
			set => SetPropertyValue<entEntityGameInterface>(value);
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("numActivatorsInArea")] 
		public CUInt32 NumActivatorsInArea
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("activatorID")] 
		public CUInt32 ActivatorID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entTriggerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
