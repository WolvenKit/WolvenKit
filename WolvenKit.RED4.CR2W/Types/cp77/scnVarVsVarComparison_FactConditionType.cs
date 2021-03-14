using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVarVsVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		private scnVarVsVarComparison_FactConditionTypeParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnVarVsVarComparison_FactConditionTypeParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnVarVsVarComparison_FactConditionTypeParams) CR2WTypeManager.Create("scnVarVsVarComparison_FactConditionTypeParams", "params", cr2w, this);
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

		public scnVarVsVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
