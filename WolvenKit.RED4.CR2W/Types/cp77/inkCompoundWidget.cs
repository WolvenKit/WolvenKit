using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompoundWidget : inkWidget
	{
		private CEnum<inkEChildOrder> _childOrder;
		private CHandle<inkMultiChildren> _children;
		private inkMargin _childMargin;

		[Ordinal(20)] 
		[RED("childOrder")] 
		public CEnum<inkEChildOrder> ChildOrder
		{
			get => GetProperty(ref _childOrder);
			set => SetProperty(ref _childOrder, value);
		}

		[Ordinal(21)] 
		[RED("children")] 
		public CHandle<inkMultiChildren> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		[Ordinal(22)] 
		[RED("childMargin")] 
		public inkMargin ChildMargin
		{
			get => GetProperty(ref _childMargin);
			set => SetProperty(ref _childMargin, value);
		}

		public inkCompoundWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
