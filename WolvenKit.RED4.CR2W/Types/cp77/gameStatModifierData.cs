using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierData : IScriptable
	{
		private CEnum<gamedataStatType> _statType;
		private CEnum<gameStatModifierType> _modifierType;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get
			{
				if (_statType == null)
				{
					_statType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "statType", cr2w, this);
				}
				return _statType;
			}
			set
			{
				if (_statType == value)
				{
					return;
				}
				_statType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("modifierType")] 
		public CEnum<gameStatModifierType> ModifierType
		{
			get
			{
				if (_modifierType == null)
				{
					_modifierType = (CEnum<gameStatModifierType>) CR2WTypeManager.Create("gameStatModifierType", "modifierType", cr2w, this);
				}
				return _modifierType;
			}
			set
			{
				if (_modifierType == value)
				{
					return;
				}
				_modifierType = value;
				PropertySet(this);
			}
		}

		public gameStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
