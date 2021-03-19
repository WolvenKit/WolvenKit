using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceController : inkWidgetLogicController
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

		public inkVideoSequenceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
