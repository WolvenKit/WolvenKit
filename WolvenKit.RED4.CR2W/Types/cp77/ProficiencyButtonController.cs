using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyButtonController : inkButtonController
	{
		private inkTextWidgetReference _labelText;
		private inkTextWidgetReference _levelText;
		private inkWidgetReference _frameHovered;
		private CHandle<inkanimProxy> _transparencyAnimationProxy;
		private CInt32 _index;

		[Ordinal(10)] 
		[RED("labelText")] 
		public inkTextWidgetReference LabelText
		{
			get
			{
				if (_labelText == null)
				{
					_labelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelText", cr2w, this);
				}
				return _labelText;
			}
			set
			{
				if (_labelText == value)
				{
					return;
				}
				_labelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get
			{
				if (_levelText == null)
				{
					_levelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelText", cr2w, this);
				}
				return _levelText;
			}
			set
			{
				if (_levelText == value)
				{
					return;
				}
				_levelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get
			{
				if (_frameHovered == null)
				{
					_frameHovered = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "frameHovered", cr2w, this);
				}
				return _frameHovered;
			}
			set
			{
				if (_frameHovered == value)
				{
					return;
				}
				_frameHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("transparencyAnimationProxy")] 
		public CHandle<inkanimProxy> TransparencyAnimationProxy
		{
			get
			{
				if (_transparencyAnimationProxy == null)
				{
					_transparencyAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "transparencyAnimationProxy", cr2w, this);
				}
				return _transparencyAnimationProxy;
			}
			set
			{
				if (_transparencyAnimationProxy == value)
				{
					return;
				}
				_transparencyAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		public ProficiencyButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
