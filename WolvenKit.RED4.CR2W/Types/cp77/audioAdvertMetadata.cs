using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAdvertMetadata : audioEmitterMetadata
	{
		private CArray<CName> _advertSoundNames;
		private CFloat _minSilenceTime;
		private CFloat _maxSilenceTime;
		private CFloat _minDistance;
		private CEnum<audioAdvertIndoorFilter> _filter;

		[Ordinal(1)] 
		[RED("advertSoundNames")] 
		public CArray<CName> AdvertSoundNames
		{
			get => GetProperty(ref _advertSoundNames);
			set => SetProperty(ref _advertSoundNames, value);
		}

		[Ordinal(2)] 
		[RED("minSilenceTime")] 
		public CFloat MinSilenceTime
		{
			get => GetProperty(ref _minSilenceTime);
			set => SetProperty(ref _minSilenceTime, value);
		}

		[Ordinal(3)] 
		[RED("maxSilenceTime")] 
		public CFloat MaxSilenceTime
		{
			get => GetProperty(ref _maxSilenceTime);
			set => SetProperty(ref _maxSilenceTime, value);
		}

		[Ordinal(4)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(5)] 
		[RED("filter")] 
		public CEnum<audioAdvertIndoorFilter> Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}

		public audioAdvertMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
