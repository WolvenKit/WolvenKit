using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameIComparisonPrereq : gameIPrereq
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<gameComparisonType> ComparisonType { get; set; }

		public gameIComparisonPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
