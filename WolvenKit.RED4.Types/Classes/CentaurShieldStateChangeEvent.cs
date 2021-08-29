using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CentaurShieldStateChangeEvent : redEvent
	{
		private CEnum<ECentaurShieldState> _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<ECentaurShieldState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
