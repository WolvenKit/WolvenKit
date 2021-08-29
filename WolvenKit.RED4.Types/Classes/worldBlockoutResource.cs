using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBlockoutResource : CResource
	{
		private CHandle<worldBlockoutData> _blockoutData;

		[Ordinal(1)] 
		[RED("blockoutData")] 
		public CHandle<worldBlockoutData> BlockoutData
		{
			get => GetProperty(ref _blockoutData);
			set => SetProperty(ref _blockoutData, value);
		}
	}
}
