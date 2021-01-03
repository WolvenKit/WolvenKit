using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimatedSign : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_AnimatedDevice> AnimFeature { get; set; }

		public AnimatedSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
