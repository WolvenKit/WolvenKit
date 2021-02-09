using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReprimandUpdate : redEvent
	{
		[Ordinal(0)]  [RED("reprimandInstructions")] public CEnum<EReprimandInstructions> ReprimandInstructions { get; set; }
		[Ordinal(1)]  [RED("target")] public entEntityID Target { get; set; }
		[Ordinal(2)]  [RED("targetPos")] public Vector4 TargetPos { get; set; }
		[Ordinal(3)]  [RED("currentPerformer")] public wCHandle<gameObject> CurrentPerformer { get; set; }

		public ReprimandUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
