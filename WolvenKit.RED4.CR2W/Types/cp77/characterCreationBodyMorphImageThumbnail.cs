using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphImageThumbnail : inkButtonAnimatedController
	{
		private inkWidgetReference _selector;
		private inkWidgetReference _equipped;
		private inkWidgetReference _bg;
		private CInt32 _index;

		[Ordinal(22)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(23)] 
		[RED("equipped")] 
		public inkWidgetReference Equipped
		{
			get => GetProperty(ref _equipped);
			set => SetProperty(ref _equipped, value);
		}

		[Ordinal(24)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get => GetProperty(ref _bg);
			set => SetProperty(ref _bg, value);
		}

		[Ordinal(25)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		public characterCreationBodyMorphImageThumbnail(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
