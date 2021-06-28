using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintGroupController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleTextRef;
		private inkTextWidgetReference _descriptionTextRef;
		private inkCompoundWidgetReference _hintsContainerRef;
		private inkImageWidgetReference _iconRef;

		[Ordinal(1)] 
		[RED("titleTextRef")] 
		public inkTextWidgetReference TitleTextRef
		{
			get => GetProperty(ref _titleTextRef);
			set => SetProperty(ref _titleTextRef, value);
		}

		[Ordinal(2)] 
		[RED("descriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get => GetProperty(ref _descriptionTextRef);
			set => SetProperty(ref _descriptionTextRef, value);
		}

		[Ordinal(3)] 
		[RED("hintsContainerRef")] 
		public inkCompoundWidgetReference HintsContainerRef
		{
			get => GetProperty(ref _hintsContainerRef);
			set => SetProperty(ref _hintsContainerRef, value);
		}

		[Ordinal(4)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetProperty(ref _iconRef);
			set => SetProperty(ref _iconRef, value);
		}

		public gameuiInputHintGroupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
