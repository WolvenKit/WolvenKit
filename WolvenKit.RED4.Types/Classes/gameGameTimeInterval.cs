using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGameTimeInterval : RedBaseClass
	{
		private GameTime _begin;
		private GameTime _end;
		private CBool _ignoreDays;

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

		[Ordinal(2)] 
		[RED("ignoreDays")] 
		public CBool IgnoreDays
		{
			get => GetProperty(ref _ignoreDays);
			set => SetProperty(ref _ignoreDays, value);
		}
	}
}
