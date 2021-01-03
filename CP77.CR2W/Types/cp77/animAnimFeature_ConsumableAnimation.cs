using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ConsumableAnimation : animAnimFeature
	{
		[Ordinal(0)]  [RED("consumableType")] public CInt32 ConsumableType { get; set; }
		[Ordinal(1)]  [RED("useConsumable")] public CBool UseConsumable { get; set; }

		public animAnimFeature_ConsumableAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
