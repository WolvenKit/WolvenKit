using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackGroup : effectTrackBase
	{
		private CArray<CHandle<effectTrackBase>> _tracks;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("tracks")] 
		public CArray<CHandle<effectTrackBase>> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		public effectTrackGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
