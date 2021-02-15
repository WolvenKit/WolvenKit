using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DistractionState : animAnimFeature
	{
		[Ordinal(0)] [RED("isOn")] public CBool IsOn { get; set; }

		public AnimFeature_DistractionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
