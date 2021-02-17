using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddDevelopmentPoints : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("amountOfPoints")] public CInt32 AmountOfPoints { get; set; }
		[Ordinal(2)] [RED("developmentPointType")] public CEnum<gamedataDevelopmentPointType> DevelopmentPointType { get; set; }

		public AddDevelopmentPoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
