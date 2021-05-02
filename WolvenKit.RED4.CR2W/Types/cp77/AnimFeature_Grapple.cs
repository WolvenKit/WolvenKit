using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Grapple : animAnimFeature
	{
		private CBool _inGrapple;

		[Ordinal(0)] 
		[RED("inGrapple")] 
		public CBool InGrapple
		{
			get => GetProperty(ref _inGrapple);
			set => SetProperty(ref _inGrapple, value);
		}

		public AnimFeature_Grapple(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
