using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonDpadSupportedController : inkButtonAnimatedController
	{
		private wCHandle<inkWidget> _targetPath_DpadUp;
		private wCHandle<inkWidget> _targetPath_DpadDown;
		private wCHandle<inkWidget> _targetPath_DpadLeft;
		private wCHandle<inkWidget> _targetPath_DpadRight;

		[Ordinal(22)] 
		[RED("targetPath_DpadUp")] 
		public wCHandle<inkWidget> TargetPath_DpadUp
		{
			get
			{
				if (_targetPath_DpadUp == null)
				{
					_targetPath_DpadUp = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "targetPath_DpadUp", cr2w, this);
				}
				return _targetPath_DpadUp;
			}
			set
			{
				if (_targetPath_DpadUp == value)
				{
					return;
				}
				_targetPath_DpadUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("targetPath_DpadDown")] 
		public wCHandle<inkWidget> TargetPath_DpadDown
		{
			get
			{
				if (_targetPath_DpadDown == null)
				{
					_targetPath_DpadDown = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "targetPath_DpadDown", cr2w, this);
				}
				return _targetPath_DpadDown;
			}
			set
			{
				if (_targetPath_DpadDown == value)
				{
					return;
				}
				_targetPath_DpadDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("targetPath_DpadLeft")] 
		public wCHandle<inkWidget> TargetPath_DpadLeft
		{
			get
			{
				if (_targetPath_DpadLeft == null)
				{
					_targetPath_DpadLeft = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "targetPath_DpadLeft", cr2w, this);
				}
				return _targetPath_DpadLeft;
			}
			set
			{
				if (_targetPath_DpadLeft == value)
				{
					return;
				}
				_targetPath_DpadLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("targetPath_DpadRight")] 
		public wCHandle<inkWidget> TargetPath_DpadRight
		{
			get
			{
				if (_targetPath_DpadRight == null)
				{
					_targetPath_DpadRight = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "targetPath_DpadRight", cr2w, this);
				}
				return _targetPath_DpadRight;
			}
			set
			{
				if (_targetPath_DpadRight == value)
				{
					return;
				}
				_targetPath_DpadRight = value;
				PropertySet(this);
			}
		}

		public inkButtonDpadSupportedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
