using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CoverCommandParams : IScriptable
	{
		[Ordinal(0)] [RED("exposureMethods")] public CArray<CEnum<AICoverExposureMethod>> ExposureMethods { get; set; }

		public CoverCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
