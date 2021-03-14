using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipBaseController : inkWidgetLogicController
	{
		private inkWidgetReference _root;
		private CHandle<inkanimProxy> _showHideAnim;
		private CBool _visible;
		private CBool _active;

		[Ordinal(1)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
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

		[Ordinal(2)] 
		[RED("showHideAnim")] 
		public CHandle<inkanimProxy> ShowHideAnim
		{
			get
			{
				if (_showHideAnim == null)
				{
					_showHideAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showHideAnim", cr2w, this);
				}
				return _showHideAnim;
			}
			set
			{
				if (_showHideAnim == value)
				{
					return;
				}
				_showHideAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		public WorldMapTooltipBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
