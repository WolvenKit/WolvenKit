using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreset : CVariable
	{
		[Ordinal(0)]  [RED("shaderParams")] public fxCompositionShaderParams ShaderParams { get; set; }
		[Ordinal(1)]  [RED("stateName")] public CName StateName { get; set; }
		[Ordinal(2)]  [RED("transitions")] public CArray<inkCompositionTransition> Transitions { get; set; }
		[Ordinal(3)]  [RED("useBackgroundTexture")] public CBool UseBackgroundTexture { get; set; }

		public inkCompositionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
