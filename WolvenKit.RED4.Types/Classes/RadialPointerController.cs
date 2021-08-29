using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialPointerController : inkWidgetLogicController
	{
		private inkImageWidgetReference _pointer;
		private inkImageWidgetReference _feedback;

		[Ordinal(1)] 
		[RED("pointer")] 
		public inkImageWidgetReference Pointer
		{
			get => GetProperty(ref _pointer);
			set => SetProperty(ref _pointer, value);
		}

		[Ordinal(2)] 
		[RED("feedback")] 
		public inkImageWidgetReference Feedback
		{
			get => GetProperty(ref _feedback);
			set => SetProperty(ref _feedback, value);
		}
	}
}
