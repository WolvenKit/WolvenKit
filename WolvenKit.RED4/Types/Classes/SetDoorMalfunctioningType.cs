using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDoorMalfunctioningType : redEvent
	{
		[Ordinal(0)] 
		[RED("malfunctioningType")] 
		public CEnum<EMalfunctioningType> MalfunctioningType
		{
			get => GetPropertyValue<CEnum<EMalfunctioningType>>();
			set => SetPropertyValue<CEnum<EMalfunctioningType>>(value);
		}

		public SetDoorMalfunctioningType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
