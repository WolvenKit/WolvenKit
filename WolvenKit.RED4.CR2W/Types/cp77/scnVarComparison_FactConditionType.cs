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
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public scnVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
