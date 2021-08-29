using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VoiceOverQuickHackFeedbackEvent : redEvent
	{
		private CName _voName;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("voName")] 
		public CName VoName
		{
			get => GetProperty(ref _voName);
			set => SetProperty(ref _voName, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
