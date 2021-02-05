using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetCyberspacePostFX_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("fullScreen")] public CBool FullScreen { get; set; }
		[Ordinal(2)]  [RED("vfx")] public CBool Vfx { get; set; }
		[Ordinal(3)]  [RED("initialDatamosh")] public CFloat InitialDatamosh { get; set; }
		[Ordinal(4)]  [RED("targetDatamosh")] public CFloat TargetDatamosh { get; set; }
		[Ordinal(5)]  [RED("initialTreshold")] public CFloat InitialTreshold { get; set; }
		[Ordinal(6)]  [RED("targetTreshold")] public CFloat TargetTreshold { get; set; }
		[Ordinal(7)]  [RED("timeBlend")] public CFloat TimeBlend { get; set; }

		public questSetCyberspacePostFX_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
