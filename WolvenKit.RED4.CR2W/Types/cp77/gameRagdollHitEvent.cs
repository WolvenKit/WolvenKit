using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRagdollHitEvent : gameeventsHitEvent
	{
		private CFloat _impactForce;
		private CFloat _speedDelta;
		private CFloat _heightDelta;

		[Ordinal(12)] 
		[RED("impactForce")] 
		public CFloat ImpactForce
		{
			get
			{
				if (_impactForce == null)
				{
					_impactForce = (CFloat) CR2WTypeManager.Create("Float", "impactForce", cr2w, this);
				}
				return _impactForce;
			}
			set
			{
				if (_impactForce == value)
				{
					return;
				}
				_impactForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("speedDelta")] 
		public CFloat SpeedDelta
		{
			get
			{
				if (_speedDelta == null)
				{
					_speedDelta = (CFloat) CR2WTypeManager.Create("Float", "speedDelta", cr2w, this);
				}
				return _speedDelta;
			}
			set
			{
				if (_speedDelta == value)
				{
					return;
				}
				_speedDelta = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("heightDelta")] 
		public CFloat HeightDelta
		{
			get
			{
				if (_heightDelta == null)
				{
					_heightDelta = (CFloat) CR2WTypeManager.Create("Float", "heightDelta", cr2w, this);
				}
				return _heightDelta;
			}
			set
			{
				if (_heightDelta == value)
				{
					return;
				}
				_heightDelta = value;
				PropertySet(this);
			}
		}

		public gameRagdollHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
