using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsStatusEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("staticData")] 
		public CHandle<gamedataStatusEffect_Record> StaticData
		{
			get => GetPropertyValue<CHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameeventsStatusEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
