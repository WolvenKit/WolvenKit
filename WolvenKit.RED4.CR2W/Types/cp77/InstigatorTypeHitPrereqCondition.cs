using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstigatorTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _instigatorType;

		[Ordinal(1)] 
		[RED("instigatorType")] 
		public CName InstigatorType
		{
			get
			{
				if (_instigatorType == null)
				{
					_instigatorType = (CName) CR2WTypeManager.Create("CName", "instigatorType", cr2w, this);
				}
				return _instigatorType;
			}
			set
			{
				if (_instigatorType == value)
				{
					return;
				}
				_instigatorType = value;
				PropertySet(this);
			}
		}

		public InstigatorTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
