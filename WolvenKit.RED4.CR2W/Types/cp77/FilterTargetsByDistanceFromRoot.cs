using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterTargetsByDistanceFromRoot : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] [RED("rootOffset_Z")] public CFloat RootOffset_Z { get; set; }
		[Ordinal(1)] [RED("tollerance")] public CFloat Tollerance { get; set; }

		public FilterTargetsByDistanceFromRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
