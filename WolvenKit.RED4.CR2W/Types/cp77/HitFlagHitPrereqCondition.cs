using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitFlagHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<hitFlag> _hitFlag;

		[Ordinal(1)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get
			{
				if (_hitFlag == null)
				{
					_hitFlag = (CEnum<hitFlag>) CR2WTypeManager.Create("hitFlag", "hitFlag", cr2w, this);
				}
				return _hitFlag;
			}
			set
			{
				if (_hitFlag == value)
				{
					return;
				}
				_hitFlag = value;
				PropertySet(this);
			}
		}

		public HitFlagHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
