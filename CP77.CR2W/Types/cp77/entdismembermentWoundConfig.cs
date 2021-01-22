using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfig : ISerializable
	{
		[Ordinal(0)]  [RED("ResourceSet")] public CEnum<entdismembermentResourceSetE> ResourceSet { get; set; }
		[Ordinal(1)]  [RED("WoundName")] public CName WoundName { get; set; }

		public entdismembermentWoundConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
