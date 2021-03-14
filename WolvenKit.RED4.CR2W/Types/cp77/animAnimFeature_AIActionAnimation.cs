using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_AIActionAnimation : animAnimFeature_AIAction
	{
		[Ordinal(4)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }

		public animAnimFeature_AIActionAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
