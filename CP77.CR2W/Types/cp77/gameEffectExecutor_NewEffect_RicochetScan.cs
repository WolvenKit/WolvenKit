using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_NewEffect_RicochetScan : gameEffectExecutor_NewEffect
	{
		[Ordinal(0)]  [RED("box")] public Vector4 Box { get; set; }
		[Ordinal(1)]  [RED("isPreview")] public CBool IsPreview { get; set; }

		public gameEffectExecutor_NewEffect_RicochetScan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
