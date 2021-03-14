using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProcessVendettaAchievementEvent : redEvent
	{
		private wCHandle<gameObject> _deathInstigator;

		[Ordinal(0)] 
		[RED("deathInstigator")] 
		public wCHandle<gameObject> DeathInstigator
		{
			get
			{
				if (_deathInstigator == null)
				{
					_deathInstigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "deathInstigator", cr2w, this);
				}
				return _deathInstigator;
			}
			set
			{
				if (_deathInstigator == value)
				{
					return;
				}
				_deathInstigator = value;
				PropertySet(this);
			}
		}

		public ProcessVendettaAchievementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
