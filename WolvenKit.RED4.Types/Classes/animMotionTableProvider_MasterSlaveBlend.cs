using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animMotionTableProvider_MasterSlaveBlend : animIMotionTableProvider
	{
		private CUInt8 _masterInputIdx;

		[Ordinal(5)] 
		[RED("masterInputIdx")] 
		public CUInt8 MasterInputIdx
		{
			get => GetProperty(ref _masterInputIdx);
			set => SetProperty(ref _masterInputIdx, value);
		}
	}
}
