using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entCameraData : CVariable
	{
		[Ordinal(0)] [RED("rotation")] public Quaternion Rotation { get; set; }

		public entCameraData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
