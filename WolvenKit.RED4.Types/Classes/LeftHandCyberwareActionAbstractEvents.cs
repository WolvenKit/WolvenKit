using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareActionAbstractEvents : LeftHandCyberwareEventsTransition
	{
		private CBool _projectileReleased;

		[Ordinal(0)] 
		[RED("projectileReleased")] 
		public CBool ProjectileReleased
		{
			get => GetProperty(ref _projectileReleased);
			set => SetProperty(ref _projectileReleased, value);
		}
	}
}
