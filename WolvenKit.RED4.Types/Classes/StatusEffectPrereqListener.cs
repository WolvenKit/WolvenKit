using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectPrereqListener : gameScriptStatusEffectListener
	{
		private CWeakHandle<StatusEffectPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatusEffectPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
