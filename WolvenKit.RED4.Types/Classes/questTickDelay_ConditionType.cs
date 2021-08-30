using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTickDelay_ConditionType : questITimeConditionType
	{
		private CUInt32 _tickCount;

		[Ordinal(0)] 
		[RED("tickCount")] 
		public CUInt32 TickCount
		{
			get => GetProperty(ref _tickCount);
			set => SetProperty(ref _tickCount, value);
		}

		public questTickDelay_ConditionType()
		{
			_tickCount = 1;
		}
	}
}
