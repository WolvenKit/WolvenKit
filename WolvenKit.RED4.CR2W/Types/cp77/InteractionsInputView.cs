using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionsInputView : inkWidgetLogicController
	{
		private inkWidgetReference _topArrowRef;
		private inkWidgetReference _botArrowRef;
		private inkImageWidgetReference _inputImage;
		private CBool _showArrows;
		private CBool _hasAbove;
		private CBool _hasBelow;
		private CInt32 _currentNum;
		private CInt32 _allItemsNum;
		private CName _defaultInputPartName;

		[Ordinal(1)] 
		[RED("TopArrowRef")] 
		public inkWidgetReference TopArrowRef
		{
			get
			{
				if (_topArrowRef == null)
				{
					_topArrowRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TopArrowRef", cr2w, this);
				}
				return _topArrowRef;
			}
			set
			{
				if (_topArrowRef == value)
				{
					return;
				}
				_topArrowRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BotArrowRef")] 
		public inkWidgetReference BotArrowRef
		{
			get
			{
				if (_botArrowRef == null)
				{
					_botArrowRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "BotArrowRef", cr2w, this);
				}
				return _botArrowRef;
			}
			set
			{
				if (_botArrowRef == value)
				{
					return;
				}
				_botArrowRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("InputImage")] 
		public inkImageWidgetReference InputImage
		{
			get
			{
				if (_inputImage == null)
				{
					_inputImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "InputImage", cr2w, this);
				}
				return _inputImage;
			}
			set
			{
				if (_inputImage == value)
				{
					return;
				}
				_inputImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ShowArrows")] 
		public CBool ShowArrows
		{
			get
			{
				if (_showArrows == null)
				{
					_showArrows = (CBool) CR2WTypeManager.Create("Bool", "ShowArrows", cr2w, this);
				}
				return _showArrows;
			}
			set
			{
				if (_showArrows == value)
				{
					return;
				}
				_showArrows = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("HasAbove")] 
		public CBool HasAbove
		{
			get
			{
				if (_hasAbove == null)
				{
					_hasAbove = (CBool) CR2WTypeManager.Create("Bool", "HasAbove", cr2w, this);
				}
				return _hasAbove;
			}
			set
			{
				if (_hasAbove == value)
				{
					return;
				}
				_hasAbove = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("HasBelow")] 
		public CBool HasBelow
		{
			get
			{
				if (_hasBelow == null)
				{
					_hasBelow = (CBool) CR2WTypeManager.Create("Bool", "HasBelow", cr2w, this);
				}
				return _hasBelow;
			}
			set
			{
				if (_hasBelow == value)
				{
					return;
				}
				_hasBelow = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("CurrentNum")] 
		public CInt32 CurrentNum
		{
			get
			{
				if (_currentNum == null)
				{
					_currentNum = (CInt32) CR2WTypeManager.Create("Int32", "CurrentNum", cr2w, this);
				}
				return _currentNum;
			}
			set
			{
				if (_currentNum == value)
				{
					return;
				}
				_currentNum = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("AllItemsNum")] 
		public CInt32 AllItemsNum
		{
			get
			{
				if (_allItemsNum == null)
				{
					_allItemsNum = (CInt32) CR2WTypeManager.Create("Int32", "AllItemsNum", cr2w, this);
				}
				return _allItemsNum;
			}
			set
			{
				if (_allItemsNum == value)
				{
					return;
				}
				_allItemsNum = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("DefaultInputPartName")] 
		public CName DefaultInputPartName
		{
			get
			{
				if (_defaultInputPartName == null)
				{
					_defaultInputPartName = (CName) CR2WTypeManager.Create("CName", "DefaultInputPartName", cr2w, this);
				}
				return _defaultInputPartName;
			}
			set
			{
				if (_defaultInputPartName == value)
				{
					return;
				}
				_defaultInputPartName = value;
				PropertySet(this);
			}
		}

		public InteractionsInputView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
