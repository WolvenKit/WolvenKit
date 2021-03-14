using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipProgessBarController : inkWidgetLogicController
	{
		private inkWidgetReference _progressFill;
		private inkWidgetReference _hintHolder;
		private inkWidgetReference _progressHolder;
		private inkWidgetReference _postprogressHolder;
		private inkCompoundWidgetReference _hintTextHolder;
		private inkWidgetLibraryReference _libraryPath;
		private inkTextWidgetReference _postprogressText;
		private CBool _isCraftable;
		private CBool _isCrafted;

		[Ordinal(1)] 
		[RED("progressFill")] 
		public inkWidgetReference ProgressFill
		{
			get
			{
				if (_progressFill == null)
				{
					_progressFill = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressFill", cr2w, this);
				}
				return _progressFill;
			}
			set
			{
				if (_progressFill == value)
				{
					return;
				}
				_progressFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hintHolder")] 
		public inkWidgetReference HintHolder
		{
			get
			{
				if (_hintHolder == null)
				{
					_hintHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hintHolder", cr2w, this);
				}
				return _hintHolder;
			}
			set
			{
				if (_hintHolder == value)
				{
					return;
				}
				_hintHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("progressHolder")] 
		public inkWidgetReference ProgressHolder
		{
			get
			{
				if (_progressHolder == null)
				{
					_progressHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressHolder", cr2w, this);
				}
				return _progressHolder;
			}
			set
			{
				if (_progressHolder == value)
				{
					return;
				}
				_progressHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("postprogressHolder")] 
		public inkWidgetReference PostprogressHolder
		{
			get
			{
				if (_postprogressHolder == null)
				{
					_postprogressHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "postprogressHolder", cr2w, this);
				}
				return _postprogressHolder;
			}
			set
			{
				if (_postprogressHolder == value)
				{
					return;
				}
				_postprogressHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hintTextHolder")] 
		public inkCompoundWidgetReference HintTextHolder
		{
			get
			{
				if (_hintTextHolder == null)
				{
					_hintTextHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "hintTextHolder", cr2w, this);
				}
				return _hintTextHolder;
			}
			set
			{
				if (_hintTextHolder == value)
				{
					return;
				}
				_hintTextHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get
			{
				if (_libraryPath == null)
				{
					_libraryPath = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "libraryPath", cr2w, this);
				}
				return _libraryPath;
			}
			set
			{
				if (_libraryPath == value)
				{
					return;
				}
				_libraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("postprogressText")] 
		public inkTextWidgetReference PostprogressText
		{
			get
			{
				if (_postprogressText == null)
				{
					_postprogressText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "postprogressText", cr2w, this);
				}
				return _postprogressText;
			}
			set
			{
				if (_postprogressText == value)
				{
					return;
				}
				_postprogressText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get
			{
				if (_isCraftable == null)
				{
					_isCraftable = (CBool) CR2WTypeManager.Create("Bool", "isCraftable", cr2w, this);
				}
				return _isCraftable;
			}
			set
			{
				if (_isCraftable == value)
				{
					return;
				}
				_isCraftable = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get
			{
				if (_isCrafted == null)
				{
					_isCrafted = (CBool) CR2WTypeManager.Create("Bool", "isCrafted", cr2w, this);
				}
				return _isCrafted;
			}
			set
			{
				if (_isCrafted == value)
				{
					return;
				}
				_isCrafted = value;
				PropertySet(this);
			}
		}

		public TooltipProgessBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
