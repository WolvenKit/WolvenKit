using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddDevelopmentPointEffector : gameEffector
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("tdbid")] public TweakDBID Tdbid { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<gamedataDevelopmentPointType> Type { get; set; }

		public AddDevelopmentPointEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
