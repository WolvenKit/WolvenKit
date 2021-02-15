using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CGradient : CResource
	{
		[Ordinal(1)] [RED("gradientEntries")] public CArray<rendGradientEntry> GradientEntries { get; set; }

		public CGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
