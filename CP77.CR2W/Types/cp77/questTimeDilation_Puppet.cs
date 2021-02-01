using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Puppet : questTimeDilation_NodeTypeParam
	{
		[Ordinal(0)]  [RED("globalTimeDilationOverride")] public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride { get; set; }
		[Ordinal(1)]  [RED("operation")] public CHandle<questTimeDilation_Operation> Operation { get; set; }
		[Ordinal(2)]  [RED("puppets")] public gameEntityReference Puppets { get; set; }

		public questTimeDilation_Puppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
