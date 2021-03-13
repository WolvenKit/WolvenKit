using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeComponent : entIComponent
	{
		[Ordinal(3)] [RED("structs")] public CArray<gameNetrunnerPrototypeStruct> Structs { get; set; }

		public gameNetrunnerPrototypeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
