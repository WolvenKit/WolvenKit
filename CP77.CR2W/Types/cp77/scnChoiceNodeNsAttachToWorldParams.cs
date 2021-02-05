using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToWorldParams : CVariable
	{
		[Ordinal(0)]  [RED("entityPosition")] public Vector3 EntityPosition { get; set; }
		[Ordinal(1)]  [RED("entityOrientation")] public Quaternion EntityOrientation { get; set; }
		[Ordinal(2)]  [RED("customEntityRadius")] public CFloat CustomEntityRadius { get; set; }
		[Ordinal(3)]  [RED("visualizerStyle")] public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle { get; set; }

		public scnChoiceNodeNsAttachToWorldParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
