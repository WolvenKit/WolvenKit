using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEditorForceAutoHideDistance : ISerializable
	{
		[Ordinal(0)] [RED("minAutoHideDistance")] public CFloat MinAutoHideDistance { get; set; }
		[Ordinal(1)] [RED("multiplier")] public CFloat Multiplier { get; set; }

		public worldEditorForceAutoHideDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
