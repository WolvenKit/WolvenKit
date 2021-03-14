using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExhaustedEvents : StaminaEventsTransition
	{
		private CHandle<worldEffectBlackboard> _staminaVfxBlackboard;

		[Ordinal(1)] 
		[RED("staminaVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> StaminaVfxBlackboard
		{
			get
			{
				if (_staminaVfxBlackboard == null)
				{
					_staminaVfxBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "staminaVfxBlackboard", cr2w, this);
				}
				return _staminaVfxBlackboard;
			}
			set
			{
				if (_staminaVfxBlackboard == value)
				{
					return;
				}
				_staminaVfxBlackboard = value;
				PropertySet(this);
			}
		}

		public ExhaustedEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
