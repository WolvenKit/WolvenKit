using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopNodeTransformInfo : CVariable
	{
		[Ordinal(0)]  [RED("id")] public interopStringWithID Id { get; set; }
		[Ordinal(1)]  [RED("transformInfo")] public interopTransformInfo TransformInfo { get; set; }

		public interopNodeTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
