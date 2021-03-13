using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableItemObject : gameItemObject
	{
		[Ordinal(43)] [RED("inspectableClues")] public CArray<SInspectableClue> InspectableClues { get; set; }

		public InspectableItemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
