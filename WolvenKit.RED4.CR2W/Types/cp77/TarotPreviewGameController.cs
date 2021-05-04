using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotPreviewGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _background;
		private inkImageWidgetReference _previewImage;
		private inkTextWidgetReference _previewTitle;
		private inkTextWidgetReference _previewDescription;
		private CHandle<TarotCardPreviewData> _data;

		[Ordinal(2)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(3)] 
		[RED("previewImage")] 
		public inkImageWidgetReference PreviewImage
		{
			get => GetProperty(ref _previewImage);
			set => SetProperty(ref _previewImage, value);
		}

		[Ordinal(4)] 
		[RED("previewTitle")] 
		public inkTextWidgetReference PreviewTitle
		{
			get => GetProperty(ref _previewTitle);
			set => SetProperty(ref _previewTitle, value);
		}

		[Ordinal(5)] 
		[RED("previewDescription")] 
		public inkTextWidgetReference PreviewDescription
		{
			get => GetProperty(ref _previewDescription);
			set => SetProperty(ref _previewDescription, value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public TarotPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
