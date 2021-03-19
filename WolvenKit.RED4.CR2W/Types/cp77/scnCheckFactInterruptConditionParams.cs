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
			get => GetProperty(ref _factCondition);
			set => SetProperty(ref _factCondition, value);
		}

		public scnCheckFactInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
