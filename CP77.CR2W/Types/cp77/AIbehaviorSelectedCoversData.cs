using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectedCoversData : IScriptable
	{
		[Ordinal(0)]  [RED("coverRingTypes")] public CArray<CEnum<gamedataAIRingType>> CoverRingTypes { get; set; }
		[Ordinal(1)]  [RED("coversUseLOS")] public CArray<CBool> CoversUseLOS { get; set; }
		[Ordinal(2)]  [RED("selectedCovers")] public CArray<CUInt64> SelectedCovers { get; set; }
		[Ordinal(3)]  [RED("sourcePresetName")] public CArray<CName> SourcePresetName { get; set; }

		public AIbehaviorSelectedCoversData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
