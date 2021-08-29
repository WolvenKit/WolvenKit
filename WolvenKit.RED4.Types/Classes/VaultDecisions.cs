using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VaultDecisions : LocomotionGroundDecisions
	{
		private CBool _stateBodyDone;

		[Ordinal(3)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetProperty(ref _stateBodyDone);
			set => SetProperty(ref _stateBodyDone, value);
		}
	}
}
