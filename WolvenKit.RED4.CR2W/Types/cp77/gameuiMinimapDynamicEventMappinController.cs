using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapDynamicEventMappinController : gameuiBaseMinimapMappinController
	{
		private CBool _pulseEnabled;
		private inkWidgetReference _pulseWidget;
		private CFloat _hideAtDistance;
		private CBool _hideInCombat;
		private CHandle<inkanimProxy> _pulseAnim;

		[Ordinal(14)] 
		[RED("pulseEnabled")] 
		public CBool PulseEnabled
		{
			get
			{
				if (_pulseEnabled == null)
				{
					_pulseEnabled = (CBool) CR2WTypeManager.Create("Bool", "pulseEnabled", cr2w, this);
				}
				return _pulseEnabled;
			}
			set
			{
				if (_pulseEnabled == value)
				{
					return;
				}
				_pulseEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get
			{
				if (_pulseWidget == null)
				{
					_pulseWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pulseWidget", cr2w, this);
				}
				return _pulseWidget;
			}
			set
			{
				if (_pulseWidget == value)
				{
					return;
				}
				_pulseWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("hideAtDistance")] 
		public CFloat HideAtDistance
		{
			get
			{
				if (_hideAtDistance == null)
				{
					_hideAtDistance = (CFloat) CR2WTypeManager.Create("Float", "hideAtDistance", cr2w, this);
				}
				return _hideAtDistance;
			}
			set
			{
				if (_hideAtDistance == value)
				{
					return;
				}
				_hideAtDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hideInCombat")] 
		public CBool HideInCombat
		{
			get
			{
				if (_hideInCombat == null)
				{
					_hideInCombat = (CBool) CR2WTypeManager.Create("Bool", "hideInCombat", cr2w, this);
				}
				return _hideInCombat;
			}
			set
			{
				if (_hideInCombat == value)
				{
					return;
				}
				_hideInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("pulseAnim")] 
		public CHandle<inkanimProxy> PulseAnim
		{
			get
			{
				if (_pulseAnim == null)
				{
					_pulseAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "pulseAnim", cr2w, this);
				}
				return _pulseAnim;
			}
			set
			{
				if (_pulseAnim == value)
				{
					return;
				}
				_pulseAnim = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapDynamicEventMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
