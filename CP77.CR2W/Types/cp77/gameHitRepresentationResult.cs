using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResult : CVariable
	{
		[Ordinal(0)]  [RED("sult")] public gameQueryResult Sult { get; set; }
		[Ordinal(1)]  [RED("tityID")] public entEntityID TityID { get; set; }

		public gameHitRepresentationResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
