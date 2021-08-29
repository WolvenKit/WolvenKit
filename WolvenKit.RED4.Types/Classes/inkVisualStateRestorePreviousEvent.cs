using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVisualStateRestorePreviousEvent : redEvent
	{
		private CName _visualState;

		[Ordinal(0)] 
		[RED("visualState")] 
		public CName VisualState
		{
			get => GetProperty(ref _visualState);
			set => SetProperty(ref _visualState, value);
		}
	}
}
