using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDiscreteNavigationController : inkWidgetLogicController
	{
		private CBool _shouldUpdateScrollController;
		private CBool _isNavigalbe;
		private CBool _supportsHoldInput;

		[Ordinal(1)] 
		[RED("shouldUpdateScrollController")] 
		public CBool ShouldUpdateScrollController
		{
			get
			{
				if (_shouldUpdateScrollController == null)
				{
					_shouldUpdateScrollController = (CBool) CR2WTypeManager.Create("Bool", "shouldUpdateScrollController", cr2w, this);
				}
				return _shouldUpdateScrollController;
			}
			set
			{
				if (_shouldUpdateScrollController == value)
				{
					return;
				}
				_shouldUpdateScrollController = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isNavigalbe")] 
		public CBool IsNavigalbe
		{
			get
			{
				if (_isNavigalbe == null)
				{
					_isNavigalbe = (CBool) CR2WTypeManager.Create("Bool", "isNavigalbe", cr2w, this);
				}
				return _isNavigalbe;
			}
			set
			{
				if (_isNavigalbe == value)
				{
					return;
				}
				_isNavigalbe = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("supportsHoldInput")] 
		public CBool SupportsHoldInput
		{
			get
			{
				if (_supportsHoldInput == null)
				{
					_supportsHoldInput = (CBool) CR2WTypeManager.Create("Bool", "supportsHoldInput", cr2w, this);
				}
				return _supportsHoldInput;
			}
			set
			{
				if (_supportsHoldInput == value)
				{
					return;
				}
				_supportsHoldInput = value;
				PropertySet(this);
			}
		}

		public inkDiscreteNavigationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
