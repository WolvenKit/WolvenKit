using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveAllStatusEffectOfTypeEvent : redEvent
	{
		private CEnum<gamedataStatusEffectType> _statusEffectType;

		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get
			{
				if (_statusEffectType == null)
				{
					_statusEffectType = (CEnum<gamedataStatusEffectType>) CR2WTypeManager.Create("gamedataStatusEffectType", "statusEffectType", cr2w, this);
				}
				return _statusEffectType;
			}
			set
			{
				if (_statusEffectType == value)
				{
					return;
				}
				_statusEffectType = value;
				PropertySet(this);
			}
		}

		public RemoveAllStatusEffectOfTypeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
