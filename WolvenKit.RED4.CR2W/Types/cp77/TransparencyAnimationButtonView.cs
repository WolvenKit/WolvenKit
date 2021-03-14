using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransparencyAnimationButtonView : BaseButtonView
	{
		private CFloat _animationTime;
		private CFloat _hoverTransparency;
		private CFloat _pressTransparency;
		private CFloat _defaultTransparency;
		private CFloat _disabledTransparency;
		private CArray<CHandle<inkanimProxy>> _animationProxies;
		private CArray<inkWidgetReference> _targets;

		[Ordinal(2)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get
			{
				if (_animationTime == null)
				{
					_animationTime = (CFloat) CR2WTypeManager.Create("Float", "AnimationTime", cr2w, this);
				}
				return _animationTime;
			}
			set
			{
				if (_animationTime == value)
				{
					return;
				}
				_animationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("HoverTransparency")] 
		public CFloat HoverTransparency
		{
			get
			{
				if (_hoverTransparency == null)
				{
					_hoverTransparency = (CFloat) CR2WTypeManager.Create("Float", "HoverTransparency", cr2w, this);
				}
				return _hoverTransparency;
			}
			set
			{
				if (_hoverTransparency == value)
				{
					return;
				}
				_hoverTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("PressTransparency")] 
		public CFloat PressTransparency
		{
			get
			{
				if (_pressTransparency == null)
				{
					_pressTransparency = (CFloat) CR2WTypeManager.Create("Float", "PressTransparency", cr2w, this);
				}
				return _pressTransparency;
			}
			set
			{
				if (_pressTransparency == value)
				{
					return;
				}
				_pressTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("DefaultTransparency")] 
		public CFloat DefaultTransparency
		{
			get
			{
				if (_defaultTransparency == null)
				{
					_defaultTransparency = (CFloat) CR2WTypeManager.Create("Float", "DefaultTransparency", cr2w, this);
				}
				return _defaultTransparency;
			}
			set
			{
				if (_defaultTransparency == value)
				{
					return;
				}
				_defaultTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("DisabledTransparency")] 
		public CFloat DisabledTransparency
		{
			get
			{
				if (_disabledTransparency == null)
				{
					_disabledTransparency = (CFloat) CR2WTypeManager.Create("Float", "DisabledTransparency", cr2w, this);
				}
				return _disabledTransparency;
			}
			set
			{
				if (_disabledTransparency == value)
				{
					return;
				}
				_disabledTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("AnimationProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimationProxies
		{
			get
			{
				if (_animationProxies == null)
				{
					_animationProxies = (CArray<CHandle<inkanimProxy>>) CR2WTypeManager.Create("array:handle:inkanimProxy", "AnimationProxies", cr2w, this);
				}
				return _animationProxies;
			}
			set
			{
				if (_animationProxies == value)
				{
					return;
				}
				_animationProxies = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "Targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		public TransparencyAnimationButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
