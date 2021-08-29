using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimProfileData_RootItem : ISerializable
	{
		private CFloat _timeMS;
		private CArray<CHandle<animAnimProfilerData_TreeItem>> _children;

		[Ordinal(0)] 
		[RED("timeMS")] 
		public CFloat TimeMS
		{
			get => GetProperty(ref _timeMS);
			set => SetProperty(ref _timeMS, value);
		}

		[Ordinal(1)] 
		[RED("children")] 
		public CArray<CHandle<animAnimProfilerData_TreeItem>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}
	}
}
