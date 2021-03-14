using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeToggle : inkToggleController
	{
		private inkWidgetReference _selectedWidget;
		private inkWidgetReference _frameWidget;
		private inkImageWidgetReference _iconWidget;
		private inkTextWidgetReference _labelWidget;
		private wCHandle<PhotoModeTopBarController> _photoModeGroupController;
		private CHandle<inkanimProxy> _fadeAnim;
		private CHandle<inkanimProxy> _fade2Anim;

		[Ordinal(13)] 
		[RED("SelectedWidget")] 
		public inkWidgetReference SelectedWidget
		{
			get
			{
				if (_selectedWidget == null)
				{
					_selectedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SelectedWidget", cr2w, this);
				}
				return _selectedWidget;
			}
			set
			{
				if (_selectedWidget == value)
				{
					return;
				}
				_selectedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("FrameWidget")] 
		public inkWidgetReference FrameWidget
		{
			get
			{
				if (_frameWidget == null)
				{
					_frameWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "FrameWidget", cr2w, this);
				}
				return _frameWidget;
			}
			set
			{
				if (_frameWidget == value)
				{
					return;
				}
				_frameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("IconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "IconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("LabelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get
			{
				if (_labelWidget == null)
				{
					_labelWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LabelWidget", cr2w, this);
				}
				return _labelWidget;
			}
			set
			{
				if (_labelWidget == value)
				{
					return;
				}
				_labelWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("photoModeGroupController")] 
		public wCHandle<PhotoModeTopBarController> PhotoModeGroupController
		{
			get
			{
				if (_photoModeGroupController == null)
				{
					_photoModeGroupController = (wCHandle<PhotoModeTopBarController>) CR2WTypeManager.Create("whandle:PhotoModeTopBarController", "photoModeGroupController", cr2w, this);
				}
				return _photoModeGroupController;
			}
			set
			{
				if (_photoModeGroupController == value)
				{
					return;
				}
				_photoModeGroupController = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get
			{
				if (_fadeAnim == null)
				{
					_fadeAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "fadeAnim", cr2w, this);
				}
				return _fadeAnim;
			}
			set
			{
				if (_fadeAnim == value)
				{
					return;
				}
				_fadeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("fade2Anim")] 
		public CHandle<inkanimProxy> Fade2Anim
		{
			get
			{
				if (_fade2Anim == null)
				{
					_fade2Anim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "fade2Anim", cr2w, this);
				}
				return _fade2Anim;
			}
			set
			{
				if (_fade2Anim == value)
				{
					return;
				}
				_fade2Anim = value;
				PropertySet(this);
			}
		}

		public PhotoModeToggle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
