using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetNPCTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataNPCType> _type;

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataNPCType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataNPCType>) CR2WTypeManager.Create("gamedataNPCType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public TargetNPCTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
