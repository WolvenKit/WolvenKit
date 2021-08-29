using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitCallback : gameScriptedDamageSystemListener
	{
		private CWeakHandle<GenericHitPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<GenericHitPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
