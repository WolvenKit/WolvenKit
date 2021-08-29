using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IterateModulesRequest : gameScriptableSystemRequest
	{
		private CArray<HUDJob> _remainingJobs;

		[Ordinal(0)] 
		[RED("remainingJobs")] 
		public CArray<HUDJob> RemainingJobs
		{
			get => GetProperty(ref _remainingJobs);
			set => SetProperty(ref _remainingJobs, value);
		}
	}
}
