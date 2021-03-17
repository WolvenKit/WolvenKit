using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsDistrictEnteredEvent : gameScriptableSystemRequest
	{
		private CBool _entered;
		private CBool _sendNewLocationNotification;
		private TweakDBID _district;

		[Ordinal(0)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetProperty(ref _entered);
			set => SetProperty(ref _entered, value);
		}

		[Ordinal(1)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get => GetProperty(ref _sendNewLocationNotification);
			set => SetProperty(ref _sendNewLocationNotification, value);
		}

		[Ordinal(2)] 
		[RED("district")] 
		public TweakDBID District
		{
			get => GetProperty(ref _district);
			set => SetProperty(ref _district, value);
		}

		public gamemappinsDistrictEnteredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
