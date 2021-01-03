using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextAnswer : CVariable
	{
		[Ordinal(0)]  [RED("answerContext")] public CName AnswerContext { get; set; }
		[Ordinal(1)]  [RED("radius")] public CFloat Radius { get; set; }

		public audioVoiceContextAnswer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
