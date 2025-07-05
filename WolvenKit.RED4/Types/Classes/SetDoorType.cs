using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDoorType : redEvent
	{
		[Ordinal(0)] 
		[RED("doorTypeSideOne")] 
		public CEnum<EDoorType> DoorTypeSideOne
		{
			get => GetPropertyValue<CEnum<EDoorType>>();
			set => SetPropertyValue<CEnum<EDoorType>>(value);
		}

		[Ordinal(1)] 
		[RED("doorTypeSideTwo")] 
		public CEnum<EDoorType> DoorTypeSideTwo
		{
			get => GetPropertyValue<CEnum<EDoorType>>();
			set => SetPropertyValue<CEnum<EDoorType>>(value);
		}

		public SetDoorType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
