using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ForkliftDevice : animAnimFeature
	{
		[Ordinal(0)]  [RED("distract")] public CBool Distract { get; set; }
		[Ordinal(1)]  [RED("isDown")] public CBool IsDown { get; set; }
		[Ordinal(2)]  [RED("isUp")] public CBool IsUp { get; set; }

		public AnimFeature_ForkliftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
