using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolPrereqListener : BaseStatPoolPrereqListener
	{
		private CWeakHandle<StatPoolPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatPoolPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
