using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporalPrereq : gameIScriptablePrereq
	{
		private CFloat _totalDuration;

		[Ordinal(0)] 
		[RED("totalDuration")] 
		public CFloat TotalDuration
		{
			get => GetProperty(ref _totalDuration);
			set => SetProperty(ref _totalDuration, value);
		}
	}
}
