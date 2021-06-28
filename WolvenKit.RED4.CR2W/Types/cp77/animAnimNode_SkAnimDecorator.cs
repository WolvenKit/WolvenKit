using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimDecorator : animAnimNode_SkAnim
	{
		private animPoseLink _fallback;

		[Ordinal(30)] 
		[RED("Fallback")] 
		public animPoseLink Fallback
		{
			get => GetProperty(ref _fallback);
			set => SetProperty(ref _fallback, value);
		}

		public animAnimNode_SkAnimDecorator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
