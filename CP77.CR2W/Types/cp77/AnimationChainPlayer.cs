using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimationChainPlayer : IScriptable
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("current")] public CHandle<AnimationChain> Current { get; set; }
		[Ordinal(2)]  [RED("current_stage")] public CInt32 Current_stage { get; set; }
		[Ordinal(3)]  [RED("next")] public CHandle<AnimationChain> Next { get; set; }
		[Ordinal(4)]  [RED("owner")] public wCHandle<inkWidgetLogicController> Owner { get; set; }

		public AnimationChainPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
