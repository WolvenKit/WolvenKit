using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeContainer : CVariable
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("physicsMaterial")] public physicsMaterialReference PhysicsMaterial { get; set; }
		[Ordinal(3)]  [RED("shape")] public CHandle<gameIHitShape> Shape { get; set; }
		[Ordinal(4)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)]  [RED("userData")] public CHandle<gameHitShapeUserData> UserData { get; set; }

		public gameHitShapeContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
