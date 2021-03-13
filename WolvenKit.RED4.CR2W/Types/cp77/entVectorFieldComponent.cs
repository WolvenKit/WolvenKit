using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVectorFieldComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("direction")] public Vector3 Direction { get; set; }
		[Ordinal(9)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entVectorFieldComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
