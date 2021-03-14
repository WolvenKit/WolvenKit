using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NonStealthQuickHackVictimEvent : redEvent
	{
		private entEntityID _instigatorID;

		[Ordinal(0)] 
		[RED("instigatorID")] 
		public entEntityID InstigatorID
		{
			get
			{
				if (_instigatorID == null)
				{
					_instigatorID = (entEntityID) CR2WTypeManager.Create("entEntityID", "instigatorID", cr2w, this);
				}
				return _instigatorID;
			}
			set
			{
				if (_instigatorID == value)
				{
					return;
				}
				_instigatorID = value;
				PropertySet(this);
			}
		}

		public NonStealthQuickHackVictimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
