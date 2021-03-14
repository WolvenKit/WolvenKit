using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataDamageType> _damageType;

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

		public DamageTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
