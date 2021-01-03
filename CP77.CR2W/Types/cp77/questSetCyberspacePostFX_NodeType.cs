using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetCyberspacePostFX_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("fullScreen")] public CBool FullScreen { get; set; }
		[Ordinal(2)]  [RED("initialDatamosh")] public CFloat InitialDatamosh { get; set; }
		[Ordinal(3)]  [RED("initialTreshold")] public CFloat InitialTreshold { get; set; }
		[Ordinal(4)]  [RED("targetDatamosh")] public CFloat TargetDatamosh { get; set; }
		[Ordinal(5)]  [RED("targetTreshold")] public CFloat TargetTreshold { get; set; }
		[Ordinal(6)]  [RED("timeBlend")] public CFloat TimeBlend { get; set; }
		[Ordinal(7)]  [RED("vfx")] public CBool Vfx { get; set; }

		public questSetCyberspacePostFX_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
