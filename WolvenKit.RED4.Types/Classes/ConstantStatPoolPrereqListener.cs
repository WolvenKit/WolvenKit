using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConstantStatPoolPrereqListener : BaseStatPoolPrereqListener
	{
		private CWeakHandle<ConstantStatPoolPrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<ConstantStatPoolPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
