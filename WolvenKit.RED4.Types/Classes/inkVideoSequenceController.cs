using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVideoSequenceController : inkWidgetLogicController
	{
		private inkVideoWidgetReference _videoWidget;
		private CArray<inkVideoSequenceEntry> _videoSequence;

		[Ordinal(1)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(2)] 
		[RED("videoSequence")] 
		public CArray<inkVideoSequenceEntry> VideoSequence
		{
			get => GetProperty(ref _videoSequence);
			set => SetProperty(ref _videoSequence, value);
		}
	}
}
