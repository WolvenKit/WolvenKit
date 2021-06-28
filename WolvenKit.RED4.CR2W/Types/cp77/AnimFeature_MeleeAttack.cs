using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_MeleeAttack : animAnimFeature
	{
		private CBool _hit;

		[Ordinal(0)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetProperty(ref _hit);
			set => SetProperty(ref _hit, value);
		}

		public AnimFeature_MeleeAttack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
