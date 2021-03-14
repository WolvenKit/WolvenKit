using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISetHealthRegenerationState : AIbehaviortaskScript
	{
		private CBool _healthRegeneration;

		[Ordinal(0)] 
		[RED("healthRegeneration")] 
		public CBool HealthRegeneration
		{
			get
			{
				if (_healthRegeneration == null)
				{
					_healthRegeneration = (CBool) CR2WTypeManager.Create("Bool", "healthRegeneration", cr2w, this);
				}
				return _healthRegeneration;
			}
			set
			{
				if (_healthRegeneration == value)
				{
					return;
				}
				_healthRegeneration = value;
				PropertySet(this);
			}
		}

		public AISetHealthRegenerationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
