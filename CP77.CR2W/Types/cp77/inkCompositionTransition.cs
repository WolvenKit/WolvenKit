using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCompositionTransition : CVariable
	{
		[Ordinal(0)]  [RED("interpolators")] public CArray<inkCompositionInterpolator> Interpolators { get; set; }
		[Ordinal(1)]  [RED("targetState")] public CName TargetState { get; set; }

		public inkCompositionTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
