using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWwiseIgnoredNames : audioAudioMetadata
	{
		private CArray<CName> _ignoredNames;

		[Ordinal(1)] 
		[RED("ignoredNames")] 
		public CArray<CName> IgnoredNames
		{
			get => GetProperty(ref _ignoredNames);
			set => SetProperty(ref _ignoredNames, value);
		}

		public audioWwiseIgnoredNames(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
