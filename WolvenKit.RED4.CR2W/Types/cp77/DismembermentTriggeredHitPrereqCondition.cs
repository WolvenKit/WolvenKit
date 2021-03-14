using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentTriggeredHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataStatusEffectType> _dotType;

		[Ordinal(1)] 
		[RED("dotType")] 
		public CEnum<gamedataStatusEffectType> DotType
		{
			get
			{
				if (_dotType == null)
				{
					_dotType = (CEnum<gamedataStatusEffectType>) CR2WTypeManager.Create("gamedataStatusEffectType", "dotType", cr2w, this);
				}
				return _dotType;
			}
			set
			{
				if (_dotType == value)
				{
					return;
				}
				_dotType = value;
				PropertySet(this);
			}
		}

		public DismembermentTriggeredHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
