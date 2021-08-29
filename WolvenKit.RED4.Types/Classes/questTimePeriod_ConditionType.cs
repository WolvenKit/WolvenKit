using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTimePeriod_ConditionType : questITimeConditionType
	{
		private GameTime _begin;
		private GameTime _end;

		[Ordinal(0)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get => GetProperty(ref _begin);
			set => SetProperty(ref _begin, value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public GameTime End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}
	}
}
