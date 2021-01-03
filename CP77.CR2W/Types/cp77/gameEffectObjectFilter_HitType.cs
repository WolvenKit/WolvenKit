using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitType : gameEffectObjectSingleFilter
	{
		[Ordinal(0)]  [RED("action")] public CEnum<gameEffectObjectFilter_HitTypeAction> Action { get; set; }
		[Ordinal(1)]  [RED("hitType")] public CEnum<gameEffectHitDataType> HitType { get; set; }

		public gameEffectObjectFilter_HitType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
