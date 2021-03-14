using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentStatusEffect : AIStatusEffectCondition
	{
		private CEnum<gamedataStatusEffectType> _statusEffectTypeToCompare;
		private CName _statusEffectTagToCompare;

		[Ordinal(0)] 
		[RED("statusEffectTypeToCompare")] 
		public CEnum<gamedataStatusEffectType> StatusEffectTypeToCompare
		{
			get
			{
				if (_statusEffectTypeToCompare == null)
				{
					_statusEffectTypeToCompare = (CEnum<gamedataStatusEffectType>) CR2WTypeManager.Create("gamedataStatusEffectType", "statusEffectTypeToCompare", cr2w, this);
				}
				return _statusEffectTypeToCompare;
			}
			set
			{
				if (_statusEffectTypeToCompare == value)
				{
					return;
				}
				_statusEffectTypeToCompare = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statusEffectTagToCompare")] 
		public CName StatusEffectTagToCompare
		{
			get
			{
				if (_statusEffectTagToCompare == null)
				{
					_statusEffectTagToCompare = (CName) CR2WTypeManager.Create("CName", "statusEffectTagToCompare", cr2w, this);
				}
				return _statusEffectTagToCompare;
			}
			set
			{
				if (_statusEffectTagToCompare == value)
				{
					return;
				}
				_statusEffectTagToCompare = value;
				PropertySet(this);
			}
		}

		public CheckCurrentStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
