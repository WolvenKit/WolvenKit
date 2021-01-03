using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LineSpawnData : IScriptable
	{
		[Ordinal(0)]  [RED("lineData")] public scnDialogLineData LineData { get; set; }

		public LineSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
