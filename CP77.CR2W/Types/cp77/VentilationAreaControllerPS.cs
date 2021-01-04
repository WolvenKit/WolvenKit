using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("ventilationAreaSetup")] public VentilationAreaSetup VentilationAreaSetup { get; set; }

		public VentilationAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
