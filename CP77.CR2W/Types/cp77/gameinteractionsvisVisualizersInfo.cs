using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisVisualizersInfo : CVariable
	{
		[Ordinal(0)]  [RED("activeVisId")] public CInt32 ActiveVisId { get; set; }
		[Ordinal(1)]  [RED("visIds")] public CArray<CInt32> VisIds { get; set; }

		public gameinteractionsvisVisualizersInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
