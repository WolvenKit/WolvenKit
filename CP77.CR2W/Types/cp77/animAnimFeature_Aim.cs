using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Aim : animAnimFeature_BasicAim
	{
		[Ordinal(0)]  [RED("aimPoint")] public Vector4 AimPoint { get; set; }

		public animAnimFeature_Aim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
