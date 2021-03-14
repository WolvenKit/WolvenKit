using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimateAnchorOnHoverView : inkWidgetLogicController
	{
		private inkWidgetReference _raycaster;
		private CHandle<inkanimProxy> _animProxy;
		private Vector2 _hoverAnchor;
		private Vector2 _normalAnchor;
		private CFloat _animTime;

		[Ordinal(1)] 
		[RED("Raycaster")] 
		public inkWidgetReference Raycaster
		{
			get
			{
				if (_raycaster == null)
				{
					_raycaster = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Raycaster", cr2w, this);
				}
				return _raycaster;
			}
			set
			{
				if (_raycaster == value)
				{
					return;
				}
				_raycaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AnimProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("HoverAnchor")] 
		public Vector2 HoverAnchor
		{
			get
			{
				if (_hoverAnchor == null)
				{
					_hoverAnchor = (Vector2) CR2WTypeManager.Create("Vector2", "HoverAnchor", cr2w, this);
				}
				return _hoverAnchor;
			}
			set
			{
				if (_hoverAnchor == value)
				{
					return;
				}
				_hoverAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("NormalAnchor")] 
		public Vector2 NormalAnchor
		{
			get
			{
				if (_normalAnchor == null)
				{
					_normalAnchor = (Vector2) CR2WTypeManager.Create("Vector2", "NormalAnchor", cr2w, this);
				}
				return _normalAnchor;
			}
			set
			{
				if (_normalAnchor == value)
				{
					return;
				}
				_normalAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("AnimTime")] 
		public CFloat AnimTime
		{
			get
			{
				if (_animTime == null)
				{
					_animTime = (CFloat) CR2WTypeManager.Create("Float", "AnimTime", cr2w, this);
				}
				return _animTime;
			}
			set
			{
				if (_animTime == value)
				{
					return;
				}
				_animTime = value;
				PropertySet(this);
			}
		}

		public AnimateAnchorOnHoverView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
