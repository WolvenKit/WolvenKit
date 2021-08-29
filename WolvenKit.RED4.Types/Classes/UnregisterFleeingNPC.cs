using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterFleeingNPC : gameScriptableSystemRequest
	{
		private CWeakHandle<entEntity> _runner;

		[Ordinal(0)] 
		[RED("runner")] 
		public CWeakHandle<entEntity> Runner
		{
			get => GetProperty(ref _runner);
			set => SetProperty(ref _runner, value);
		}
	}
}
