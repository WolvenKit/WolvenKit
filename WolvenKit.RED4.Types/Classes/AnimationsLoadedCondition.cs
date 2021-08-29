using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimationsLoadedCondition : AIbehaviorconditionScript
	{
		private CBool _coreAnims;
		private CBool _melee;

		[Ordinal(0)] 
		[RED("coreAnims")] 
		public CBool CoreAnims
		{
			get => GetProperty(ref _coreAnims);
			set => SetProperty(ref _coreAnims, value);
		}

		[Ordinal(1)] 
		[RED("melee")] 
		public CBool Melee
		{
			get => GetProperty(ref _melee);
			set => SetProperty(ref _melee, value);
		}
	}
}
