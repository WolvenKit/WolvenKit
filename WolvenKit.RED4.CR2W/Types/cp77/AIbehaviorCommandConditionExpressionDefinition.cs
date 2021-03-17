using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCommandConditionExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CName _commandName;
		private CBool _useInheritance;
		private CBool _isEnqueued;
		private CBool _isExecuting;

		[Ordinal(0)] 
		[RED("commandName")] 
		public CName CommandName
		{
			get => GetProperty(ref _commandName);
			set => SetProperty(ref _commandName, value);
		}

		[Ordinal(1)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetProperty(ref _useInheritance);
			set => SetProperty(ref _useInheritance, value);
		}

		[Ordinal(2)] 
		[RED("isEnqueued")] 
		public CBool IsEnqueued
		{
			get => GetProperty(ref _isEnqueued);
			set => SetProperty(ref _isEnqueued, value);
		}

		[Ordinal(3)] 
		[RED("isExecuting")] 
		public CBool IsExecuting
		{
			get => GetProperty(ref _isExecuting);
			set => SetProperty(ref _isExecuting, value);
		}

		public AIbehaviorCommandConditionExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
