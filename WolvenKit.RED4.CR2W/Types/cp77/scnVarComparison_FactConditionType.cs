using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		private scnVarComparison_FactConditionTypeParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnVarComparison_FactConditionTypeParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnVarComparison_FactConditionTypeParams) CR2WTypeManager.Create("scnVarComparison_FactConditionTypeParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public scnVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
