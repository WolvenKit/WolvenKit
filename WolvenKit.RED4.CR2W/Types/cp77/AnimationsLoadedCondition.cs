using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationsLoadedCondition : AIbehaviorconditionScript
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

		public AnimationsLoadedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
