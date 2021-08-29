using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPlayerProximityStopEvent : redEvent
	{
		private CName _profile;

		[Ordinal(0)] 
		[RED("profile")] 
		public CName Profile
		{
			get => GetProperty(ref _profile);
			set => SetProperty(ref _profile, value);
		}
	}
}
