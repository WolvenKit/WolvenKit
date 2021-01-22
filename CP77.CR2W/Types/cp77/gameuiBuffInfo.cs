using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBuffInfo : CVariable
	{
		[Ordinal(0)]  [RED("buffID")] public TweakDBID BuffID { get; set; }
		[Ordinal(1)]  [RED("timeRemaining")] public CFloat TimeRemaining { get; set; }

		public gameuiBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
