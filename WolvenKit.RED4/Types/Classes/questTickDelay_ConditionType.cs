using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTickDelay_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] 
		[RED("tickCount")] 
		public CUInt32 TickCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questTickDelay_ConditionType()
		{
			TickCount = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
