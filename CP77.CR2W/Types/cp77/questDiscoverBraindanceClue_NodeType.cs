using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDiscoverBraindanceClue_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("clueName")] public CName ClueName { get; set; }

		public questDiscoverBraindanceClue_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
