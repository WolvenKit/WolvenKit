using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entColliderComponentShape : ISerializable
	{
		[Ordinal(0)] [RED("localToBody")] public Transform LocalToBody { get; set; }

		public entColliderComponentShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
