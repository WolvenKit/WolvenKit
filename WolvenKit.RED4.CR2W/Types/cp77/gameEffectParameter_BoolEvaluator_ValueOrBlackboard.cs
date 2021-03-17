using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_BoolEvaluator_ValueOrBlackboard : gameIEffectParameter_BoolEvaluator
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;
		private CBool _value;

		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetProperty(ref _blackboardProperty);
			set => SetProperty(ref _blackboardProperty, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gameEffectParameter_BoolEvaluator_ValueOrBlackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
