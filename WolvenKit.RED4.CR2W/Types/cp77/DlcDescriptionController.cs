using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DlcDescriptionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _descriptionRef;
		private inkTextWidgetReference _guideRef;
		private inkImageWidgetReference _imageRef;

		[Ordinal(1)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetProperty(ref _titleRef);
			set => SetProperty(ref _titleRef, value);
		}

		[Ordinal(2)] 
		[RED("descriptionRef")] 
		public inkTextWidgetReference DescriptionRef
		{
			get => GetProperty(ref _descriptionRef);
			set => SetProperty(ref _descriptionRef, value);
		}

		[Ordinal(3)] 
		[RED("guideRef")] 
		public inkTextWidgetReference GuideRef
		{
			get => GetProperty(ref _guideRef);
			set => SetProperty(ref _guideRef, value);
		}

		[Ordinal(4)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get => GetProperty(ref _imageRef);
			set => SetProperty(ref _imageRef, value);
		}

		public DlcDescriptionController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
