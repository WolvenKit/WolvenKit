using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CandleControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _candleSkillChecks;

		[Ordinal(103)] 
		[RED("candleSkillChecks")] 
		public CHandle<EngDemoContainer> CandleSkillChecks
		{
			get
			{
				if (_candleSkillChecks == null)
				{
					_candleSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "candleSkillChecks", cr2w, this);
				}
				return _candleSkillChecks;
			}
			set
			{
				if (_candleSkillChecks == value)
				{
					return;
				}
				_candleSkillChecks = value;
				PropertySet(this);
			}
		}

		public CandleControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
