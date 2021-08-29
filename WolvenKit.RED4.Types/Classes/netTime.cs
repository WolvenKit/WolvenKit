using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netTime : RedBaseClass
	{
		private CUInt64 _milliSecs;

		[Ordinal(0)] 
		[RED("milliSecs")] 
		public CUInt64 MilliSecs
		{
			get => GetProperty(ref _milliSecs);
			set => SetProperty(ref _milliSecs, value);
		}
	}
}
