using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSlotComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("slots")] 
		public CArray<entSlot> Slots
		{
			get => GetPropertyValue<CArray<entSlot>>();
			set => SetPropertyValue<CArray<entSlot>>(value);
		}

		[Ordinal(6)] 
		[RED("fallbackSlots")] 
		public CArray<entFallbackSlot> FallbackSlots
		{
			get => GetPropertyValue<CArray<entFallbackSlot>>();
			set => SetPropertyValue<CArray<entFallbackSlot>>(value);
		}

		public entSlotComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Slots = new();
			FallbackSlots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
