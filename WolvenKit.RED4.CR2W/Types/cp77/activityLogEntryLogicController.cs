using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class activityLogEntryLogicController : inkWidgetLogicController
	{
		private CBool _available;
		private CUInt16 _originalSize;
		private CUInt16 _size;
		private CString _displayText;
		private wCHandle<inkTextWidget> _root;
		private CHandle<inkanimController> _appearingAnim;
		private CHandle<inkanimController> _typingAnim;
		private CHandle<inkanimController> _disappearingAnim;
		private CHandle<inkanimDefinition> _typingAnimDef;
		private CHandle<inkanimProxy> _typingAnimProxy;
		private CHandle<inkanimDefinition> _disappearingAnimDef;
		private CHandle<inkanimProxy> _disappearingAnimProxy;

		[Ordinal(1)] 
		[RED("available")] 
		public CBool Available
		{
			get
			{
				if (_available == null)
				{
					_available = (CBool) CR2WTypeManager.Create("Bool", "available", cr2w, this);
				}
				return _available;
			}
			set
			{
				if (_available == value)
				{
					return;
				}
				_available = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("originalSize")] 
		public CUInt16 OriginalSize
		{
			get
			{
				if (_originalSize == null)
				{
					_originalSize = (CUInt16) CR2WTypeManager.Create("Uint16", "originalSize", cr2w, this);
				}
				return _originalSize;
			}
			set
			{
				if (_originalSize == value)
				{
					return;
				}
				_originalSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("size")] 
		public CUInt16 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CUInt16) CR2WTypeManager.Create("Uint16", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("displayText")] 
		public CString DisplayText
		{
			get
			{
				if (_displayText == null)
				{
					_displayText = (CString) CR2WTypeManager.Create("String", "displayText", cr2w, this);
				}
				return _displayText;
			}
			set
			{
				if (_displayText == value)
				{
					return;
				}
				_displayText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("root")] 
		public wCHandle<inkTextWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("appearingAnim")] 
		public CHandle<inkanimController> AppearingAnim
		{
			get
			{
				if (_appearingAnim == null)
				{
					_appearingAnim = (CHandle<inkanimController>) CR2WTypeManager.Create("handle:inkanimController", "appearingAnim", cr2w, this);
				}
				return _appearingAnim;
			}
			set
			{
				if (_appearingAnim == value)
				{
					return;
				}
				_appearingAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("typingAnim")] 
		public CHandle<inkanimController> TypingAnim
		{
			get
			{
				if (_typingAnim == null)
				{
					_typingAnim = (CHandle<inkanimController>) CR2WTypeManager.Create("handle:inkanimController", "typingAnim", cr2w, this);
				}
				return _typingAnim;
			}
			set
			{
				if (_typingAnim == value)
				{
					return;
				}
				_typingAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("disappearingAnim")] 
		public CHandle<inkanimController> DisappearingAnim
		{
			get
			{
				if (_disappearingAnim == null)
				{
					_disappearingAnim = (CHandle<inkanimController>) CR2WTypeManager.Create("handle:inkanimController", "disappearingAnim", cr2w, this);
				}
				return _disappearingAnim;
			}
			set
			{
				if (_disappearingAnim == value)
				{
					return;
				}
				_disappearingAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("typingAnimDef")] 
		public CHandle<inkanimDefinition> TypingAnimDef
		{
			get
			{
				if (_typingAnimDef == null)
				{
					_typingAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "typingAnimDef", cr2w, this);
				}
				return _typingAnimDef;
			}
			set
			{
				if (_typingAnimDef == value)
				{
					return;
				}
				_typingAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("typingAnimProxy")] 
		public CHandle<inkanimProxy> TypingAnimProxy
		{
			get
			{
				if (_typingAnimProxy == null)
				{
					_typingAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "typingAnimProxy", cr2w, this);
				}
				return _typingAnimProxy;
			}
			set
			{
				if (_typingAnimProxy == value)
				{
					return;
				}
				_typingAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("disappearingAnimDef")] 
		public CHandle<inkanimDefinition> DisappearingAnimDef
		{
			get
			{
				if (_disappearingAnimDef == null)
				{
					_disappearingAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "disappearingAnimDef", cr2w, this);
				}
				return _disappearingAnimDef;
			}
			set
			{
				if (_disappearingAnimDef == value)
				{
					return;
				}
				_disappearingAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("disappearingAnimProxy")] 
		public CHandle<inkanimProxy> DisappearingAnimProxy
		{
			get
			{
				if (_disappearingAnimProxy == null)
				{
					_disappearingAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "disappearingAnimProxy", cr2w, this);
				}
				return _disappearingAnimProxy;
			}
			set
			{
				if (_disappearingAnimProxy == value)
				{
					return;
				}
				_disappearingAnimProxy = value;
				PropertySet(this);
			}
		}

		public activityLogEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
