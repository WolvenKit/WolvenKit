using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleCameraManagerComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("perspective")] public CEnum<vehicleCameraPerspective> Perspective { get; set; }

		public vehicleCameraManagerComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
