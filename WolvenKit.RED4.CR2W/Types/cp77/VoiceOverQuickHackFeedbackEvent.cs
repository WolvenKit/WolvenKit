using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VoiceOverQuickHackFeedbackEvent : redEvent
	{
		private CName _voName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("voName")] 
		public CName VoName
		{
			get => GetProperty(ref _voName);
			set => SetProperty(ref _voName, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public VoiceOverQuickHackFeedbackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
