using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MusicSettings : IScriptable
	{
		private CEnum<ESoundStatusEffects> _statusEffect;

		[Ordinal(0)] 
		[RED("statusEffect")] 
		public CEnum<ESoundStatusEffects> StatusEffect
		{
			get
			{
				if (_statusEffect == null)
				{
					_statusEffect = (CEnum<ESoundStatusEffects>) CR2WTypeManager.Create("ESoundStatusEffects", "statusEffect", cr2w, this);
				}
				return _statusEffect;
			}
			set
			{
				if (_statusEffect == value)
				{
					return;
				}
				_statusEffect = value;
				PropertySet(this);
			}
		}

		public MusicSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
