using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearest_Pierce : gameEffectObjectFilter_OnlyNearest
	{
		[Ordinal(0)]  [RED("alwaysApplyFullWeaponCharge")] public CBool AlwaysApplyFullWeaponCharge { get; set; }

		public gameEffectObjectFilter_OnlyNearest_Pierce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
