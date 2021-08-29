using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LODBegin : animAnimNode_OnePoseInput
	{
		private CUInt32 _levelOfDetail;

		[Ordinal(12)] 
		[RED("levelOfDetail")] 
		public CUInt32 LevelOfDetail
		{
			get => GetProperty(ref _levelOfDetail);
			set => SetProperty(ref _levelOfDetail, value);
		}
	}
}
