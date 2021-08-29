using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIBuffInfo : gameuiBuffInfo
	{
		private CBool _isBuff;
		private CUInt32 _stackCount;

		[Ordinal(2)] 
		[RED("isBuff")] 
		public CBool IsBuff
		{
			get => GetProperty(ref _isBuff);
			set => SetProperty(ref _isBuff, value);
		}

		[Ordinal(3)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get => GetProperty(ref _stackCount);
			set => SetProperty(ref _stackCount, value);
		}
	}
}
