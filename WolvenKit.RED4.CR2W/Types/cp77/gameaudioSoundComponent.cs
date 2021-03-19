using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponent : gameaudioSoundComponentBase
	{
		private CArray<gameaudioSoundComponentSubSystemWrapper> _subSystems;
		private CName _voEventOverride;
		private CFloat _minVocalizationRepeatTime;
		private CFloat _streamingDistance;

		[Ordinal(11)] 
		[RED("subSystems")] 
		public CArray<gameaudioSoundComponentSubSystemWrapper> SubSystems
		{
			get => GetProperty(ref _subSystems);
			set => SetProperty(ref _subSystems, value);
		}

		[Ordinal(12)] 
		[RED("voEventOverride")] 
		public CName VoEventOverride
		{
			get => GetProperty(ref _voEventOverride);
			set => SetProperty(ref _voEventOverride, value);
		}

		[Ordinal(13)] 
		[RED("minVocalizationRepeatTime")] 
		public CFloat MinVocalizationRepeatTime
		{
			get => GetProperty(ref _minVocalizationRepeatTime);
			set => SetProperty(ref _minVocalizationRepeatTime, value);
		}

		[Ordinal(14)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		public gameaudioSoundComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
