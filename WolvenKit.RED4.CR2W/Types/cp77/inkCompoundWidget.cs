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
			get
			{
				if (_childOrder == null)
				{
					_childOrder = (CEnum<inkEChildOrder>) CR2WTypeManager.Create("inkEChildOrder", "childOrder", cr2w, this);
				}
				return _childOrder;
			}
			set
			{
				if (_childOrder == value)
				{
					return;
				}
				_childOrder = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("children")] 
		public CHandle<inkMultiChildren> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CHandle<inkMultiChildren>) CR2WTypeManager.Create("handle:inkMultiChildren", "children", cr2w, this);
				}
				return _children;
			}
			set
			{
				if (_children == value)
				{
					return;
				}
				_children = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("childMargin")] 
		public inkMargin ChildMargin
		{
			get
			{
				if (_childMargin == null)
				{
					_childMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "childMargin", cr2w, this);
				}
				return _childMargin;
			}
			set
			{
				if (_childMargin == value)
				{
					return;
				}
				_childMargin = value;
				PropertySet(this);
			}
		}

		public inkCompoundWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
