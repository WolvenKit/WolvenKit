using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LevelUpdateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("lvl")] 
		public CInt32 Lvl
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get => GetPropertyValue<CArray<SDevelopmentPoints>>();
			set => SetPropertyValue<CArray<SDevelopmentPoints>>(value);
		}

		public LevelUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
