using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _imageView;

		[Ordinal(1)] 
		[RED("imageView")] 
		public inkImageWidgetReference ImageView
		{
			get => GetProperty(ref _imageView);
			set => SetProperty(ref _imageView, value);
		}

		public AnimationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
