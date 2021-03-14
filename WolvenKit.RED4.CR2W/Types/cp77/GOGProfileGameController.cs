using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GOGProfileGameController : gameuiBaseGOGProfileController
	{
		private inkWidgetReference _retryButton;
		private inkWidgetReference _parentContainerWidget;
		private CBool _isFirstLogin;
		private CBool _showingFirstLogin;
		private CBool _canRetry;

		[Ordinal(2)] 
		[RED("retryButton")] 
		public inkWidgetReference RetryButton
		{
			get
			{
				if (_retryButton == null)
				{
					_retryButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "retryButton", cr2w, this);
				}
				return _retryButton;
			}
			set
			{
				if (_retryButton == value)
				{
					return;
				}
				_retryButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("parentContainerWidget")] 
		public inkWidgetReference ParentContainerWidget
		{
			get
			{
				if (_parentContainerWidget == null)
				{
					_parentContainerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "parentContainerWidget", cr2w, this);
				}
				return _parentContainerWidget;
			}
			set
			{
				if (_parentContainerWidget == value)
				{
					return;
				}
				_parentContainerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isFirstLogin")] 
		public CBool IsFirstLogin
		{
			get
			{
				if (_isFirstLogin == null)
				{
					_isFirstLogin = (CBool) CR2WTypeManager.Create("Bool", "isFirstLogin", cr2w, this);
				}
				return _isFirstLogin;
			}
			set
			{
				if (_isFirstLogin == value)
				{
					return;
				}
				_isFirstLogin = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("showingFirstLogin")] 
		public CBool ShowingFirstLogin
		{
			get
			{
				if (_showingFirstLogin == null)
				{
					_showingFirstLogin = (CBool) CR2WTypeManager.Create("Bool", "showingFirstLogin", cr2w, this);
				}
				return _showingFirstLogin;
			}
			set
			{
				if (_showingFirstLogin == value)
				{
					return;
				}
				_showingFirstLogin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("canRetry")] 
		public CBool CanRetry
		{
			get
			{
				if (_canRetry == null)
				{
					_canRetry = (CBool) CR2WTypeManager.Create("Bool", "canRetry", cr2w, this);
				}
				return _canRetry;
			}
			set
			{
				if (_canRetry == value)
				{
					return;
				}
				_canRetry = value;
				PropertySet(this);
			}
		}

		public GOGProfileGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
