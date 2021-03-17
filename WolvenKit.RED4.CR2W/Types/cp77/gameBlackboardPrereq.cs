using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPrereq : gameIComparisonPrereq
	{
		private gameBlackboardPropertyBindingDefinition _blackboardValue;
		private CVariant _value;

		[Ordinal(1)] 
		[RED("blackboardValue")] 
		public gameBlackboardPropertyBindingDefinition BlackboardValue
		{
			get => GetProperty(ref _blackboardValue);
			set => SetProperty(ref _blackboardValue, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gameBlackboardPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
