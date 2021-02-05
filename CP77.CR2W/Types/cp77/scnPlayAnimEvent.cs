using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayAnimEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("animData")] public scneventsPlayAnimEventExData AnimData { get; set; }
		[Ordinal(1)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(2)]  [RED("actorComponent")] public CName ActorComponent { get; set; }
		[Ordinal(3)]  [RED("convertToAdditive")] public CBool ConvertToAdditive { get; set; }
		[Ordinal(4)]  [RED("muteAnimEvents")] public CEnum<animMuteAnimEvents> MuteAnimEvents { get; set; }
		[Ordinal(5)]  [RED("neckWeight")] public CFloat NeckWeight { get; set; }
		[Ordinal(6)]  [RED("upperFaceBlendAdditive")] public CBool UpperFaceBlendAdditive { get; set; }
		[Ordinal(7)]  [RED("lowerFaceBlendAdditive")] public CBool LowerFaceBlendAdditive { get; set; }
		[Ordinal(8)]  [RED("eyesBlendAdditive")] public CBool EyesBlendAdditive { get; set; }

		public scnPlayAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
