using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneMessageNotificationViewData : gameuiQuestUpdateNotificationViewData
	{
		private CInt32 _threadHash;
		private CInt32 _contactHash;

		[Ordinal(14)] 
		[RED("threadHash")] 
		public CInt32 ThreadHash
		{
			get => GetProperty(ref _threadHash);
			set => SetProperty(ref _threadHash, value);
		}

		[Ordinal(15)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get => GetProperty(ref _contactHash);
			set => SetProperty(ref _contactHash, value);
		}

		public gameuiPhoneMessageNotificationViewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
