using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfigContainer : ISerializable
	{
		[Ordinal(0)] [RED("AppearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(1)] [RED("Wounds")] public CArray<entdismembermentWoundConfig> Wounds { get; set; }

		public entdismembermentWoundConfigContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
