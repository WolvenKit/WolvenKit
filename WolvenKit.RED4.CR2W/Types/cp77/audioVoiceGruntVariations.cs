using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceGruntVariations : CVariable
	{
		private CArray<CName> _cachedVariations;

		[Ordinal(0)] 
		[RED("cachedVariations")] 
		public CArray<CName> CachedVariations
		{
			get => GetProperty(ref _cachedVariations);
			set => SetProperty(ref _cachedVariations, value);
		}

		public audioVoiceGruntVariations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
