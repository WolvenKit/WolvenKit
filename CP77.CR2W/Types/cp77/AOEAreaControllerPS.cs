using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AOEAreaControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("AOEAreaSetup")] public AOEAreaSetup AOEAreaSetup { get; set; }

		public AOEAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
