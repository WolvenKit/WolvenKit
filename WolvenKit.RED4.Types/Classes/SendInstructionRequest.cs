using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SendInstructionRequest : gameScriptableSystemRequest
	{
		private CArray<HUDJob> _jobs;

		[Ordinal(0)] 
		[RED("jobs")] 
		public CArray<HUDJob> Jobs
		{
			get => GetProperty(ref _jobs);
			set => SetProperty(ref _jobs, value);
		}
	}
}
