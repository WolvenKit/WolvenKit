using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRollingListController : inkListController
	{
		private CInt32 _itemsToDisplay;
		private CFloat _convexity;
		private CFloat _verticalCompression;
		private CFloat _scrollTime;

		[Ordinal(6)] 
		[RED("itemsToDisplay")] 
		public CInt32 ItemsToDisplay
		{
			get
			{
				if (_itemsToDisplay == null)
				{
					_itemsToDisplay = (CInt32) CR2WTypeManager.Create("Int32", "itemsToDisplay", cr2w, this);
				}
				return _itemsToDisplay;
			}
			set
			{
				if (_itemsToDisplay == value)
				{
					return;
				}
				_itemsToDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("convexity")] 
		public CFloat Convexity
		{
			get
			{
				if (_convexity == null)
				{
					_convexity = (CFloat) CR2WTypeManager.Create("Float", "convexity", cr2w, this);
				}
				return _convexity;
			}
			set
			{
				if (_convexity == value)
				{
					return;
				}
				_convexity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("verticalCompression")] 
		public CFloat VerticalCompression
		{
			get
			{
				if (_verticalCompression == null)
				{
					_verticalCompression = (CFloat) CR2WTypeManager.Create("Float", "verticalCompression", cr2w, this);
				}
				return _verticalCompression;
			}
			set
			{
				if (_verticalCompression == value)
				{
					return;
				}
				_verticalCompression = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("scrollTime")] 
		public CFloat ScrollTime
		{
			get
			{
				if (_scrollTime == null)
				{
					_scrollTime = (CFloat) CR2WTypeManager.Create("Float", "scrollTime", cr2w, this);
				}
				return _scrollTime;
			}
			set
			{
				if (_scrollTime == value)
				{
					return;
				}
				_scrollTime = value;
				PropertySet(this);
			}
		}

		public inkRollingListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
