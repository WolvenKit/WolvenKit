using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LookAtData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("personality")] 
		public CEnum<gamedataStatType> Personality
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public LookAtData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
