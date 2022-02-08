using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheAnimationForPotentialRagdoll : RagdollTask
	{
		[Ordinal(0)] 
		[RED("currentBehavior")] 
		public CName CurrentBehavior
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
