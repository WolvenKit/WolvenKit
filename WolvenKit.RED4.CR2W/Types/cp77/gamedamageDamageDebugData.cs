using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageDamageDebugData : IScriptable
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CEnum<gamedataDamageType> _damageType;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (CEnum<gamedataDamageType>) CR2WTypeManager.Create("gamedataDamageType", "damageType", cr2w, this);
				}
				return _damageType;
			}
			set
			{
				if (_damageType == value)
				{
					return;
				}
				_damageType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gamedamageDamageDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
