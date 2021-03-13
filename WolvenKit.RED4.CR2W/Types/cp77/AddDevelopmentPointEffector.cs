using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddDevelopmentPointEffector : gameEffector
	{
		[Ordinal(0)] [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<gamedataDevelopmentPointType> Type { get; set; }
		[Ordinal(2)] [RED("tdbid")] public TweakDBID Tdbid { get; set; }

		public AddDevelopmentPointEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
