using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CellData : CVariable
	{
		[Ordinal(0)] [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(1)] [RED("element")] public ElementData Element { get; set; }
		[Ordinal(2)] [RED("properties")] public SpecialProperties Properties { get; set; }
		[Ordinal(3)] [RED("assignedCell")] public wCHandle<NetworkMinigameGridCellController> AssignedCell { get; set; }
		[Ordinal(4)] [RED("consumed")] public CBool Consumed { get; set; }

		public CellData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
