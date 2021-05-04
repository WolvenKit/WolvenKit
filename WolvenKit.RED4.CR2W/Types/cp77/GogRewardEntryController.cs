using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardEntryController : inkWidgetLogicController
	{
		private inkWidgetReference _nameWidget;
		private inkWidgetReference _descriptionWidget;
		private inkImageWidgetReference _iconImage;

		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkWidgetReference NameWidget
		{
			get => GetProperty(ref _nameWidget);
			set => SetProperty(ref _nameWidget, value);
		}

		[Ordinal(2)] 
		[RED("descriptionWidget")] 
		public inkWidgetReference DescriptionWidget
		{
			get => GetProperty(ref _descriptionWidget);
			set => SetProperty(ref _descriptionWidget, value);
		}

		[Ordinal(3)] 
		[RED("iconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetProperty(ref _iconImage);
			set => SetProperty(ref _iconImage, value);
		}

		public GogRewardEntryController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
