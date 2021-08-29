using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entShadowMeshChangeEvent : redEvent
	{
		private CEnum<entAppearanceStatus> _requestedState;

		[Ordinal(0)] 
		[RED("requestedState")] 
		public CEnum<entAppearanceStatus> RequestedState
		{
			get => GetProperty(ref _requestedState);
			set => SetProperty(ref _requestedState, value);
		}
	}
}
