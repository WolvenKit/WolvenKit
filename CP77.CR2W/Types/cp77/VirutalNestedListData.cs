using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VirutalNestedListData : IScriptable
	{
		[Ordinal(0)]  [RED("collapsable")] public CBool Collapsable { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<IScriptable> Data { get; set; }
		[Ordinal(2)]  [RED("isHeader")] public CBool IsHeader { get; set; }
		[Ordinal(3)]  [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(4)]  [RED("widgetType")] public CUInt32 WidgetType { get; set; }

		public VirutalNestedListData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
