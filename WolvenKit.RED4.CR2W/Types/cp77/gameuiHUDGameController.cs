using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDGameController : gameuiWidgetGameController
	{
		private CHandle<inkanimDefinition> _showAnimDef;
		private CHandle<inkanimDefinition> _hideAnimDef;
		private CName _showAnimationName;
		private CName _hideAnimationName;
		private CBool _moduleShown;
		private CHandle<inkanimProxy> _showAnimProxy;
		private CHandle<inkanimProxy> _hideAnimProxy;

		[Ordinal(2)] 
		[RED("showAnimDef")] 
		public CHandle<inkanimDefinition> ShowAnimDef
		{
			get
			{
				if (_showAnimDef == null)
				{
					_showAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "showAnimDef", cr2w, this);
				}
				return _showAnimDef;
			}
			set
			{
				if (_showAnimDef == value)
				{
					return;
				}
				_showAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hideAnimDef")] 
		public CHandle<inkanimDefinition> HideAnimDef
		{
			get
			{
				if (_hideAnimDef == null)
				{
					_hideAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "hideAnimDef", cr2w, this);
				}
				return _hideAnimDef;
			}
			set
			{
				if (_hideAnimDef == value)
				{
					return;
				}
				_hideAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("showAnimationName")] 
		public CName ShowAnimationName
		{
			get
			{
				if (_showAnimationName == null)
				{
					_showAnimationName = (CName) CR2WTypeManager.Create("CName", "showAnimationName", cr2w, this);
				}
				return _showAnimationName;
			}
			set
			{
				if (_showAnimationName == value)
				{
					return;
				}
				_showAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hideAnimationName")] 
		public CName HideAnimationName
		{
			get
			{
				if (_hideAnimationName == null)
				{
					_hideAnimationName = (CName) CR2WTypeManager.Create("CName", "hideAnimationName", cr2w, this);
				}
				return _hideAnimationName;
			}
			set
			{
				if (_hideAnimationName == value)
				{
					return;
				}
				_hideAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("moduleShown")] 
		public CBool ModuleShown
		{
			get
			{
				if (_moduleShown == null)
				{
					_moduleShown = (CBool) CR2WTypeManager.Create("Bool", "moduleShown", cr2w, this);
				}
				return _moduleShown;
			}
			set
			{
				if (_moduleShown == value)
				{
					return;
				}
				_moduleShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get
			{
				if (_showAnimProxy == null)
				{
					_showAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showAnimProxy", cr2w, this);
				}
				return _showAnimProxy;
			}
			set
			{
				if (_showAnimProxy == value)
				{
					return;
				}
				_showAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hideAnimProxy")] 
		public CHandle<inkanimProxy> HideAnimProxy
		{
			get
			{
				if (_hideAnimProxy == null)
				{
					_hideAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hideAnimProxy", cr2w, this);
				}
				return _hideAnimProxy;
			}
			set
			{
				if (_hideAnimProxy == value)
				{
					return;
				}
				_hideAnimProxy = value;
				PropertySet(this);
			}
		}

		public gameuiHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
