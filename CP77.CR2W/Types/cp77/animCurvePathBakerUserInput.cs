using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerUserInput : CVariable
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("controllersSetupName")] public CName ControllersSetupName { get; set; }
		[Ordinal(2)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(3)]  [RED("useStop")] public CBool UseStop { get; set; }

		public animCurvePathBakerUserInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
