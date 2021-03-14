using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDeviceProximityEvent : redEvent
	{
		private entEntityID _instigator;

		[Ordinal(0)] 
		[RED("instigator")] 
		public entEntityID Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (entEntityID) CR2WTypeManager.Create("entEntityID", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		public ExplosiveTriggerDeviceProximityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
