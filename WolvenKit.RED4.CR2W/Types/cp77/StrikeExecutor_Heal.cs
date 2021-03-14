using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StrikeExecutor_Heal : gameEffectExecutor_Scripted
	{
		private CFloat _healthPerc;

		[Ordinal(1)] 
		[RED("healthPerc")] 
		public CFloat HealthPerc
		{
			get
			{
				if (_healthPerc == null)
				{
					_healthPerc = (CFloat) CR2WTypeManager.Create("Float", "healthPerc", cr2w, this);
				}
				return _healthPerc;
			}
			set
			{
				if (_healthPerc == value)
				{
					return;
				}
				_healthPerc = value;
				PropertySet(this);
			}
		}

		public StrikeExecutor_Heal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
