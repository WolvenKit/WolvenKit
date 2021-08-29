using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeAnimFeatureChangeEvent : redEvent
	{
		private CInt32 _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CInt32 NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
