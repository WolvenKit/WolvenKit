using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeAdjustTransform : IScriptable
	{
		[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(1)] [RED("rotation")] public Quaternion Rotation { get; set; }

		public gamestateMachineparameterTypeAdjustTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
