using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoLogicController : inkWidgetLogicController
	{
		private CUInt32 _count;
		private CUInt32 _capacity;

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(2)] 
		[RED("capacity")] 
		public CUInt32 Capacity
		{
			get => GetProperty(ref _capacity);
			set => SetProperty(ref _capacity, value);
		}
	}
}
