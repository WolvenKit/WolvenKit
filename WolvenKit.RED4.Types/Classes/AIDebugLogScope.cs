using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDebugLogScope : RedBaseClass
	{
		private CUInt32 _index;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
