using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGridItem : RedBaseClass
	{
		private CUInt32 _rootIdx;

		[Ordinal(0)] 
		[RED("rootIdx")] 
		public CUInt32 RootIdx
		{
			get => GetProperty(ref _rootIdx);
			set => SetProperty(ref _rootIdx, value);
		}

		public inkGridItem()
		{
			_rootIdx = 4294967295;
		}
	}
}
