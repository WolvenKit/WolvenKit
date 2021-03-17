using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInContextParams : CVariable
	{
		private CEnum<scnContextualActorName> _contextualName;
		private scnVoicetagId _voiceVagId;
		private CName _contextActorName;
		private TweakDBID _specRecordId;
		private CBool _forceMaxVisibility;

		[Ordinal(0)] 
		[RED("contextualName")] 
		public CEnum<scnContextualActorName> ContextualName
		{
			get => GetProperty(ref _contextualName);
			set => SetProperty(ref _contextualName, value);
		}

		[Ordinal(1)] 
		[RED("voiceVagId")] 
		public scnVoicetagId VoiceVagId
		{
			get => GetProperty(ref _voiceVagId);
			set => SetProperty(ref _voiceVagId, value);
		}

		[Ordinal(2)] 
		[RED("contextActorName")] 
		public CName ContextActorName
		{
			get => GetProperty(ref _contextActorName);
			set => SetProperty(ref _contextActorName, value);
		}

		[Ordinal(3)] 
		[RED("specRecordId")] 
		public TweakDBID SpecRecordId
		{
			get => GetProperty(ref _specRecordId);
			set => SetProperty(ref _specRecordId, value);
		}

		[Ordinal(4)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetProperty(ref _forceMaxVisibility);
			set => SetProperty(ref _forceMaxVisibility, value);
		}

		public scnFindEntityInContextParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
