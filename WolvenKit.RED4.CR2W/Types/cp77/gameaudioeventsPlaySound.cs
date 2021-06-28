using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsPlaySound : redEvent
	{
		private CName _soundName;
		private CName _emitterName;
		private CName _audioTag;
		private CFloat _seekTime;
		private CBool _playUnique;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetProperty(ref _soundName);
			set => SetProperty(ref _soundName, value);
		}

		[Ordinal(1)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		[Ordinal(2)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetProperty(ref _audioTag);
			set => SetProperty(ref _audioTag, value);
		}

		[Ordinal(3)] 
		[RED("seekTime")] 
		public CFloat SeekTime
		{
			get => GetProperty(ref _seekTime);
			set => SetProperty(ref _seekTime, value);
		}

		[Ordinal(4)] 
		[RED("playUnique")] 
		public CBool PlayUnique
		{
			get => GetProperty(ref _playUnique);
			set => SetProperty(ref _playUnique, value);
		}

		public gameaudioeventsPlaySound(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
