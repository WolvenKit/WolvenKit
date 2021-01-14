using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GridUserData : IScriptable
	{
		[Ordinal(0)]  [RED("align")] public CEnum<inkEHorizontalAlign> Align { get; set; }
		[Ordinal(1)]  [RED("equipArea")] public CEnum<gamedataEquipmentArea> EquipArea { get; set; }

		public GridUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
