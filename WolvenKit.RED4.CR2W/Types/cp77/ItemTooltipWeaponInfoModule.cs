using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipWeaponInfoModule : ItemTooltipModuleController
	{
		private inkWidgetReference _wrapper;
		private inkImageWidgetReference _arrow;
		private inkTextWidgetReference _dpsText;
		private inkTextWidgetReference _perHitText;
		private inkTextWidgetReference _attacksPerSecondText;
		private inkTextWidgetReference _nonLethal;
		private inkWidgetReference _scopeIndicator;
		private inkWidgetReference _silencerIndicator;
		private inkTextWidgetReference _ammoText;
		private inkWidgetReference _ammoWrapper;

		[Ordinal(2)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get
			{
				if (_wrapper == null)
				{
					_wrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "wrapper", cr2w, this);
				}
				return _wrapper;
			}
			set
			{
				if (_wrapper == value)
				{
					return;
				}
				_wrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get
			{
				if (_arrow == null)
				{
					_arrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrow", cr2w, this);
				}
				return _arrow;
			}
			set
			{
				if (_arrow == value)
				{
					return;
				}
				_arrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get
			{
				if (_dpsText == null)
				{
					_dpsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "dpsText", cr2w, this);
				}
				return _dpsText;
			}
			set
			{
				if (_dpsText == value)
				{
					return;
				}
				_dpsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("perHitText")] 
		public inkTextWidgetReference PerHitText
		{
			get
			{
				if (_perHitText == null)
				{
					_perHitText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "perHitText", cr2w, this);
				}
				return _perHitText;
			}
			set
			{
				if (_perHitText == value)
				{
					return;
				}
				_perHitText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("attacksPerSecondText")] 
		public inkTextWidgetReference AttacksPerSecondText
		{
			get
			{
				if (_attacksPerSecondText == null)
				{
					_attacksPerSecondText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attacksPerSecondText", cr2w, this);
				}
				return _attacksPerSecondText;
			}
			set
			{
				if (_attacksPerSecondText == value)
				{
					return;
				}
				_attacksPerSecondText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("nonLethal")] 
		public inkTextWidgetReference NonLethal
		{
			get
			{
				if (_nonLethal == null)
				{
					_nonLethal = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nonLethal", cr2w, this);
				}
				return _nonLethal;
			}
			set
			{
				if (_nonLethal == value)
				{
					return;
				}
				_nonLethal = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("scopeIndicator")] 
		public inkWidgetReference ScopeIndicator
		{
			get
			{
				if (_scopeIndicator == null)
				{
					_scopeIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scopeIndicator", cr2w, this);
				}
				return _scopeIndicator;
			}
			set
			{
				if (_scopeIndicator == value)
				{
					return;
				}
				_scopeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("silencerIndicator")] 
		public inkWidgetReference SilencerIndicator
		{
			get
			{
				if (_silencerIndicator == null)
				{
					_silencerIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "silencerIndicator", cr2w, this);
				}
				return _silencerIndicator;
			}
			set
			{
				if (_silencerIndicator == value)
				{
					return;
				}
				_silencerIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ammoText")] 
		public inkTextWidgetReference AmmoText
		{
			get
			{
				if (_ammoText == null)
				{
					_ammoText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ammoText", cr2w, this);
				}
				return _ammoText;
			}
			set
			{
				if (_ammoText == value)
				{
					return;
				}
				_ammoText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get
			{
				if (_ammoWrapper == null)
				{
					_ammoWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ammoWrapper", cr2w, this);
				}
				return _ammoWrapper;
			}
			set
			{
				if (_ammoWrapper == value)
				{
					return;
				}
				_ammoWrapper = value;
				PropertySet(this);
			}
		}

		public ItemTooltipWeaponInfoModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
