using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatData : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _modifiers;
		private CEnum<gamedataStatType> _statType;

		[Ordinal(0)] 
		[RED("modifiers")] 
		public CArray<CHandle<gameStatModifierData>> Modifiers
		{
			get
			{
				if (_modifiers == null)
				{
					_modifiers = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "modifiers", cr2w, this);
				}
				return _modifiers;
			}
			set
			{
				if (_modifiers == value)
				{
					return;
				}
				_modifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public gameStatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
