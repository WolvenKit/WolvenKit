using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheAnimationForPotentialRagdoll : RagdollTask
	{
		private CName _currentBehavior;

		[Ordinal(0)] 
		[RED("currentBehavior")] 
		public CName CurrentBehavior
		{
			get => GetProperty(ref _currentBehavior);
			set => SetProperty(ref _currentBehavior, value);
		}
	}
}
