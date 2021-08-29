using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GuardbreakReactionTask : AIHitReactionTask
	{
		private TweakDBID _tweakDBPackage;

		[Ordinal(4)] 
		[RED("tweakDBPackage")] 
		public TweakDBID TweakDBPackage
		{
			get => GetProperty(ref _tweakDBPackage);
			set => SetProperty(ref _tweakDBPackage, value);
		}
	}
}
