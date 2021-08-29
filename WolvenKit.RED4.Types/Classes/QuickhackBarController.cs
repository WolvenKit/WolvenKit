using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickhackBarController : inkWidgetLogicController
	{
		private inkWidgetReference _emptyMask;
		private inkWidgetReference _empty;
		private inkWidgetReference _full;

		[Ordinal(1)] 
		[RED("emptyMask")] 
		public inkWidgetReference EmptyMask
		{
			get => GetProperty(ref _emptyMask);
			set => SetProperty(ref _emptyMask, value);
		}

		[Ordinal(2)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(3)] 
		[RED("full")] 
		public inkWidgetReference Full
		{
			get => GetProperty(ref _full);
			set => SetProperty(ref _full, value);
		}
	}
}
