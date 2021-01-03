using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SequenceVideo : CVariable
	{
		[Ordinal(0)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(1)]  [RED("looped")] public CBool Looped { get; set; }
		[Ordinal(2)]  [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }

		public SequenceVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
