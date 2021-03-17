using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigMapItem : audioAudioMetadata
	{
		private CArray<CName> _matchingRigs;

		[Ordinal(1)] 
		[RED("matchingRigs")] 
		public CArray<CName> MatchingRigs
		{
			get => GetProperty(ref _matchingRigs);
			set => SetProperty(ref _matchingRigs, value);
		}

		public audioMeleeRigMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
