using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGOGRewardPack : RedBaseClass
	{
		private CString _id;
		private CString _title;
		private CString _reason;
		private CName _iconSlot;
		private CArray<CUInt64> _rewards;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("reason")] 
		public CString Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		[Ordinal(3)] 
		[RED("iconSlot")] 
		public CName IconSlot
		{
			get => GetProperty(ref _iconSlot);
			set => SetProperty(ref _iconSlot, value);
		}

		[Ordinal(4)] 
		[RED("rewards")] 
		public CArray<CUInt64> Rewards
		{
			get => GetProperty(ref _rewards);
			set => SetProperty(ref _rewards, value);
		}
	}
}
