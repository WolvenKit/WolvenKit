using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceEntry : CVariable
	{
		private raRef<Bink> _videoResource;
		private CName _audioEvent;
		private CBool _syncToAudio;
		private CBool _retriggerAudioOnLoop;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		[Ordinal(1)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(2)] 
		[RED("syncToAudio")] 
		public CBool SyncToAudio
		{
			get => GetProperty(ref _syncToAudio);
			set => SetProperty(ref _syncToAudio, value);
		}

		[Ordinal(3)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get => GetProperty(ref _retriggerAudioOnLoop);
			set => SetProperty(ref _retriggerAudioOnLoop, value);
		}

		[Ordinal(4)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		public inkVideoSequenceEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
