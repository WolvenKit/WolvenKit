using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAreaData : CVariable
	{
		[Ordinal(0)]  [RED("lootID")] public TweakDBID LootID { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(3)]  [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(4)]  [RED("shape")] public CEnum<gameEAreaShape> Shape { get; set; }
		[Ordinal(5)]  [RED("size")] public CFloat Size { get; set; }
		[Ordinal(6)]  [RED("type")] public CEnum<gameEAreaType> Type { get; set; }

		public gameAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
