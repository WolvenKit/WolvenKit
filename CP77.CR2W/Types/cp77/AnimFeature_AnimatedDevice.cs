using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_AnimatedDevice : animAnimFeature
	{
		[Ordinal(0)]  [RED("isOff")] public CBool IsOff { get; set; }
		[Ordinal(1)]  [RED("isOn")] public CBool IsOn { get; set; }

		public AnimFeature_AnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
