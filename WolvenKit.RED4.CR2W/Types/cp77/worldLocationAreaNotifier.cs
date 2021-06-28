using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLocationAreaNotifier : worldITriggerAreaNotifer
	{
		private TweakDBID _districtID;
		private CBool _sendNewLocationNotification;

		[Ordinal(3)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetProperty(ref _districtID);
			set => SetProperty(ref _districtID, value);
		}

		[Ordinal(4)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get => GetProperty(ref _sendNewLocationNotification);
			set => SetProperty(ref _sendNewLocationNotification, value);
		}

		public worldLocationAreaNotifier(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
