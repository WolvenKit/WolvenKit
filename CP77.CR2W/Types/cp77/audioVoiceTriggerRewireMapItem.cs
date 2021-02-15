using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerRewireMapItem : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("inputToBeRewiredVariationIndex")] public CUInt32 InputToBeRewiredVariationIndex { get; set; }
		[Ordinal(2)] [RED("inputToBeActuallyPlayedName")] public CName InputToBeActuallyPlayedName { get; set; }
		[Ordinal(3)] [RED("inputToBeActuallyPlayedVariationIndex")] public CUInt32 InputToBeActuallyPlayedVariationIndex { get; set; }
		[Ordinal(4)] [RED("allowReuse")] public CBool AllowReuse { get; set; }

		public audioVoiceTriggerRewireMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
