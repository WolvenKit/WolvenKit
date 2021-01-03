using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entIPlacedComponent : entIComponent
	{
		[Ordinal(0)]  [RED("localTransform")] public WorldTransform LocalTransform { get; set; }
		[Ordinal(1)]  [RED("parentTransform")] public CHandle<entITransformBinding> ParentTransform { get; set; }

		public entIPlacedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
