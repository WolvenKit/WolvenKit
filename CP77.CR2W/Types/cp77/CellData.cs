using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CellData : CVariable
	{
		[Ordinal(0)]  [RED("assignedCell")] public wCHandle<NetworkMinigameGridCellController> AssignedCell { get; set; }
		[Ordinal(1)]  [RED("consumed")] public CBool Consumed { get; set; }
		[Ordinal(2)]  [RED("element")] public ElementData Element { get; set; }
		[Ordinal(3)]  [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(4)]  [RED("properties")] public SpecialProperties Properties { get; set; }

		public CellData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
