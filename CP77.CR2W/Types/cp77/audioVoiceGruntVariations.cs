using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVoiceGruntVariations : CVariable
	{
		[Ordinal(0)]  [RED("cachedVariations")] public CArray<CName> CachedVariations { get; set; }

		public audioVoiceGruntVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
