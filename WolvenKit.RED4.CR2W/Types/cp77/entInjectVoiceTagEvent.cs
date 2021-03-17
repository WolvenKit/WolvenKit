using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entInjectVoiceTagEvent : redEvent
	{
		private CName _voiceTagName;
		private CBool _forceInjection;

		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get => GetProperty(ref _voiceTagName);
			set => SetProperty(ref _voiceTagName, value);
		}

		[Ordinal(1)] 
		[RED("forceInjection")] 
		public CBool ForceInjection
		{
			get => GetProperty(ref _forceInjection);
			set => SetProperty(ref _forceInjection, value);
		}

		public entInjectVoiceTagEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
