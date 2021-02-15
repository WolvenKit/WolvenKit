using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreset : CVariable
	{
		[Ordinal(0)] [RED("stateName")] public CName StateName { get; set; }
		[Ordinal(1)] [RED("useBackgroundTexture")] public CBool UseBackgroundTexture { get; set; }
		[Ordinal(2)] [RED("shaderParams")] public fxCompositionShaderParams ShaderParams { get; set; }
		[Ordinal(3)] [RED("transitions")] public CArray<inkCompositionTransition> Transitions { get; set; }

		public inkCompositionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
