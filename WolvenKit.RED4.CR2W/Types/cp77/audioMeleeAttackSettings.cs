using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeAttackSettings : CVariable
	{
		private CName _hitEvent;
		private CName _penetratingHitEvent;
		private CName _criticalHitEvent;
		private CName _killingHitEvent;

		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CName HitEvent
		{
			get
			{
				if (_hitEvent == null)
				{
					_hitEvent = (CName) CR2WTypeManager.Create("CName", "hitEvent", cr2w, this);
				}
				return _hitEvent;
			}
			set
			{
				if (_hitEvent == value)
				{
					return;
				}
				_hitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("penetratingHitEvent")] 
		public CName PenetratingHitEvent
		{
			get
			{
				if (_penetratingHitEvent == null)
				{
					_penetratingHitEvent = (CName) CR2WTypeManager.Create("CName", "penetratingHitEvent", cr2w, this);
				}
				return _penetratingHitEvent;
			}
			set
			{
				if (_penetratingHitEvent == value)
				{
					return;
				}
				_penetratingHitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("criticalHitEvent")] 
		public CName CriticalHitEvent
		{
			get
			{
				if (_criticalHitEvent == null)
				{
					_criticalHitEvent = (CName) CR2WTypeManager.Create("CName", "criticalHitEvent", cr2w, this);
				}
				return _criticalHitEvent;
			}
			set
			{
				if (_criticalHitEvent == value)
				{
					return;
				}
				_criticalHitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("killingHitEvent")] 
		public CName KillingHitEvent
		{
			get
			{
				if (_killingHitEvent == null)
				{
					_killingHitEvent = (CName) CR2WTypeManager.Create("CName", "killingHitEvent", cr2w, this);
				}
				return _killingHitEvent;
			}
			set
			{
				if (_killingHitEvent == value)
				{
					return;
				}
				_killingHitEvent = value;
				PropertySet(this);
			}
		}

		public audioMeleeAttackSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
