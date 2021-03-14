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
			get
			{
				if (_imageView == null)
				{
					_imageView = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "imageView", cr2w, this);
				}
				return _imageView;
			}
			set
			{
				if (_imageView == value)
				{
					return;
				}
				_imageView = value;
				PropertySet(this);
			}
		}

		public AnimationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
