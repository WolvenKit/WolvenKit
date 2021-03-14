using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckFactInterruptConditionParams : CVariable
	{
		private CHandle<scnInterruptFactConditionType> _factCondition;

		[Ordinal(0)] 
		[RED("factCondition")] 
		public CHandle<scnInterruptFactConditionType> FactCondition
		{
			get
			{
				if (_factCondition == null)
				{
					_factCondition = (CHandle<scnInterruptFactConditionType>) CR2WTypeManager.Create("handle:scnInterruptFactConditionType", "factCondition", cr2w, this);
				}
				return _factCondition;
			}
			set
			{
				if (_factCondition == value)
				{
					return;
				}
				_factCondition = value;
				PropertySet(this);
			}
		}

		public scnCheckFactInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
