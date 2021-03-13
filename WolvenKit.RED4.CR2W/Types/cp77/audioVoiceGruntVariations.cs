using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceGruntVariations : CVariable
	{
		[Ordinal(0)] [RED("cachedVariations")] public CArray<CName> CachedVariations { get; set; }

		public audioVoiceGruntVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
