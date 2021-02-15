using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeComponent : entIComponent
	{
		[Ordinal(3)] [RED("structs")] public CArray<gameNetrunnerPrototypeStruct> Structs { get; set; }

		public gameNetrunnerPrototypeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
