using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class tarotCardLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _image;
		private inkWidgetReference _highlight;
		private TarotCardData _data;

		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(2)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get => GetProperty(ref _highlight);
			set => SetProperty(ref _highlight, value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public TarotCardData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public tarotCardLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
