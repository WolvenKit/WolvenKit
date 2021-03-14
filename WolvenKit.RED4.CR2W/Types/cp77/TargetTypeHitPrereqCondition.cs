using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _targetType;

		[Ordinal(1)] 
		[RED("targetType")] 
		public CName TargetType
		{
			get
			{
				if (_targetType == null)
				{
					_targetType = (CName) CR2WTypeManager.Create("CName", "targetType", cr2w, this);
				}
				return _targetType;
			}
			set
			{
				if (_targetType == value)
				{
					return;
				}
				_targetType = value;
				PropertySet(this);
			}
		}

		public TargetTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
