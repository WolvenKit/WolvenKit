using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectSlotEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("relativePosition")] 
		public Vector3 RelativePosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("relativeRotation")] 
		public Quaternion RelativeRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public effectSlotEntry()
		{
			RelativePosition = new();
			RelativeRotation = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
