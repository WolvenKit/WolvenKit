using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_CNameEvaluator_ValueOrBlackboard : gameIEffectParameter_CNameEvaluator
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;
		private CName _value;

		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetProperty(ref _blackboardProperty);
			set => SetProperty(ref _blackboardProperty, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CName Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gameEffectParameter_CNameEvaluator_ValueOrBlackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
