using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_SweepOverTime_Sphere : gameEffectObjectProvider_SweepOverTime
	{
		[Ordinal(0)]  [RED("radius")] public CFloat Radius { get; set; }

		public gameEffectObjectProvider_SweepOverTime_Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
