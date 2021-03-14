using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFootPhaseChangedEvent : redEvent
	{
		private CEnum<animEFootPhase> _footPhase;

		[Ordinal(0)] 
		[RED("footPhase")] 
		public CEnum<animEFootPhase> FootPhase
		{
			get
			{
				if (_footPhase == null)
				{
					_footPhase = (CEnum<animEFootPhase>) CR2WTypeManager.Create("animEFootPhase", "footPhase", cr2w, this);
				}
				return _footPhase;
			}
			set
			{
				if (_footPhase == value)
				{
					return;
				}
				_footPhase = value;
				PropertySet(this);
			}
		}

		public entFootPhaseChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
