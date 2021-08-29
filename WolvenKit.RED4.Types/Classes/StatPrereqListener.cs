using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPrereqListener : gameScriptStatsListener
	{
		private CWeakHandle<StatPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
