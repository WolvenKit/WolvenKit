using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnPlayAnimEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("actorComponent")] public CName ActorComponent { get; set; }
		[Ordinal(1)]  [RED("animData")] public scneventsPlayAnimEventExData AnimData { get; set; }
		[Ordinal(2)]  [RED("convertToAdditive")] public CBool ConvertToAdditive { get; set; }
		[Ordinal(3)]  [RED("eyesBlendAdditive")] public CBool EyesBlendAdditive { get; set; }
		[Ordinal(4)]  [RED("lowerFaceBlendAdditive")] public CBool LowerFaceBlendAdditive { get; set; }
		[Ordinal(5)]  [RED("muteAnimEvents")] public animMuteAnimEvents MuteAnimEvents { get; set; }
		[Ordinal(6)]  [RED("neckWeight")] public CFloat NeckWeight { get; set; }
		[Ordinal(7)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(8)]  [RED("upperFaceBlendAdditive")] public CBool UpperFaceBlendAdditive { get; set; }

		public scnPlayAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
