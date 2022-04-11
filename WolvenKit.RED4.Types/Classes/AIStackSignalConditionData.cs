using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIStackSignalConditionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("lastValue")] 
		public CBool LastValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIStackSignalConditionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
