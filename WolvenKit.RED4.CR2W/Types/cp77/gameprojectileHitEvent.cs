using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileHitEvent : redEvent
	{
		private CArray<gameprojectileHitInstance> _hitInstances;

		[Ordinal(0)] 
		[RED("hitInstances")] 
		public CArray<gameprojectileHitInstance> HitInstances
		{
			get
			{
				if (_hitInstances == null)
				{
					_hitInstances = (CArray<gameprojectileHitInstance>) CR2WTypeManager.Create("array:gameprojectileHitInstance", "hitInstances", cr2w, this);
				}
				return _hitInstances;
			}
			set
			{
				if (_hitInstances == value)
				{
					return;
				}
				_hitInstances = value;
				PropertySet(this);
			}
		}

		public gameprojectileHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
