using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudRecordingController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(10)] [RED("anim_intro")] public CHandle<inkanimProxy> Anim_intro { get; set; }
		[Ordinal(11)] [RED("anim_outro")] public CHandle<inkanimProxy> Anim_outro { get; set; }
		[Ordinal(12)] [RED("anim_loop")] public CHandle<inkanimProxy> Anim_loop { get; set; }
		[Ordinal(13)] [RED("option_intro")] public inkanimPlaybackOptions Option_intro { get; set; }
		[Ordinal(14)] [RED("option_loop")] public inkanimPlaybackOptions Option_loop { get; set; }
		[Ordinal(15)] [RED("option_outro")] public inkanimPlaybackOptions Option_outro { get; set; }
		[Ordinal(16)] [RED("factListener")] public CUInt32 FactListener { get; set; }

		public hudRecordingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
