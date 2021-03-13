using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCameraManagerComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("perspective")] public CEnum<vehicleCameraPerspective> Perspective { get; set; }

		public vehicleCameraManagerComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
