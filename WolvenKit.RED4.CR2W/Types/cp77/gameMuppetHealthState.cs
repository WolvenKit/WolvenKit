using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetHealthState : CVariable
	{
		private CFloat _health;

		[Ordinal(0)] 
		[RED("health")] 
		public CFloat Health
		{
			get
			{
				if (_health == null)
				{
					_health = (CFloat) CR2WTypeManager.Create("Float", "health", cr2w, this);
				}
				return _health;
			}
			set
			{
				if (_health == value)
				{
					return;
				}
				_health = value;
				PropertySet(this);
			}
		}

		public gameMuppetHealthState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
