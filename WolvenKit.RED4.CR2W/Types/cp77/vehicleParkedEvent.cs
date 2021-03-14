using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleParkedEvent : redEvent
	{
		private CBool _park;

		[Ordinal(0)] 
		[RED("park")] 
		public CBool Park
		{
			get
			{
				if (_park == null)
				{
					_park = (CBool) CR2WTypeManager.Create("Bool", "park", cr2w, this);
				}
				return _park;
			}
			set
			{
				if (_park == value)
				{
					return;
				}
				_park = value;
				PropertySet(this);
			}
		}

		public vehicleParkedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
