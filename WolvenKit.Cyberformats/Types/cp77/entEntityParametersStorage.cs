using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersStorage : ISerializable
	{
		[Ordinal(0)] [RED("parameters")] public CArray<CHandle<entEntityParameter>> Parameters { get; set; }

		public entEntityParametersStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
