using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAudioEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CName _audioEventName;
		private CName _ambientUniqueName;
		private CName _emitterName;
		private CEnum<scnAudioFastForwardSupport> _fastForwardSupport;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetProperty(ref _audioEventName);
			set => SetProperty(ref _audioEventName, value);
		}

		[Ordinal(8)] 
		[RED("ambientUniqueName")] 
		public CName AmbientUniqueName
		{
			get => GetProperty(ref _ambientUniqueName);
			set => SetProperty(ref _ambientUniqueName, value);
		}

		[Ordinal(9)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		[Ordinal(10)] 
		[RED("fastForwardSupport")] 
		public CEnum<scnAudioFastForwardSupport> FastForwardSupport
		{
			get => GetProperty(ref _fastForwardSupport);
			set => SetProperty(ref _fastForwardSupport, value);
		}

		public scnAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
