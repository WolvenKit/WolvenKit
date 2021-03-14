using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationNavigationBtn : inkButtonController
	{
		private inkWidgetReference _icon1;
		private CBool _shouldPlaySoundOnHover;
		private CHandle<inkWidget> _root;

		[Ordinal(10)] 
		[RED("icon1")] 
		public inkWidgetReference Icon1
		{
			get
			{
				if (_icon1 == null)
				{
					_icon1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "icon1", cr2w, this);
				}
				return _icon1;
			}
			set
			{
				if (_icon1 == value)
				{
					return;
				}
				_icon1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("shouldPlaySoundOnHover")] 
		public CBool ShouldPlaySoundOnHover
		{
			get
			{
				if (_shouldPlaySoundOnHover == null)
				{
					_shouldPlaySoundOnHover = (CBool) CR2WTypeManager.Create("Bool", "shouldPlaySoundOnHover", cr2w, this);
				}
				return _shouldPlaySoundOnHover;
			}
			set
			{
				if (_shouldPlaySoundOnHover == value)
				{
					return;
				}
				_shouldPlaySoundOnHover = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
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

		public characterCreationNavigationBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
