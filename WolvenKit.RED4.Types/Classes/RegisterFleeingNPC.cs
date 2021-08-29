using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterFleeingNPC : gameScriptableSystemRequest
	{
		private CWeakHandle<entEntity> _runner;
		private CFloat _timestamp;

		[Ordinal(0)] 
		[RED("runner")] 
		public CWeakHandle<entEntity> Runner
		{
			get => GetProperty(ref _runner);
			set => SetProperty(ref _runner, value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}
	}
}
