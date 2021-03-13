using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_AirHover : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }

		public AnimFeature_AirHover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
