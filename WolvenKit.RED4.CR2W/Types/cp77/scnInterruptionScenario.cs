using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterruptionScenario : CVariable
	{
		private scnInterruptionScenarioId _id;
		private CName _name;
		private CBool _enabled;
		private CBool _talkOnReturn;
		private CBool _playInterruptLine;
		private CBool _forcePlayReturnLine;
		private CBool _interruptionSpammingSafeguard;
		private CEnum<scnInterruptReturnLinesBehavior> _playingLinesBehavior;
		private CFloat _postInterruptSignalTimeDelay;
		private CFloat _postReturnSignalTimeDelay;
		private CHandle<scnInterruptFactConditionType> _postInterruptSignalFactCondition;
		private CHandle<scnInterruptFactConditionType> _postReturnSignalFactCondition;
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;
		private CArray<CHandle<scnIReturnCondition>> _returnConditions;

		[Ordinal(0)] 
		[RED("id")] 
		public scnInterruptionScenarioId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(3)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get => GetProperty(ref _talkOnReturn);
			set => SetProperty(ref _talkOnReturn, value);
		}

		[Ordinal(4)] 
		[RED("playInterruptLine")] 
		public CBool PlayInterruptLine
		{
			get => GetProperty(ref _playInterruptLine);
			set => SetProperty(ref _playInterruptLine, value);
		}

		[Ordinal(5)] 
		[RED("forcePlayReturnLine")] 
		public CBool ForcePlayReturnLine
		{
			get => GetProperty(ref _forcePlayReturnLine);
			set => SetProperty(ref _forcePlayReturnLine, value);
		}

		[Ordinal(6)] 
		[RED("interruptionSpammingSafeguard")] 
		public CBool InterruptionSpammingSafeguard
		{
			get => GetProperty(ref _interruptionSpammingSafeguard);
			set => SetProperty(ref _interruptionSpammingSafeguard, value);
		}

		[Ordinal(7)] 
		[RED("playingLinesBehavior")] 
		public CEnum<scnInterruptReturnLinesBehavior> PlayingLinesBehavior
		{
			get => GetProperty(ref _playingLinesBehavior);
			set => SetProperty(ref _playingLinesBehavior, value);
		}

		[Ordinal(8)] 
		[RED("postInterruptSignalTimeDelay")] 
		public CFloat PostInterruptSignalTimeDelay
		{
			get => GetProperty(ref _postInterruptSignalTimeDelay);
			set => SetProperty(ref _postInterruptSignalTimeDelay, value);
		}

		[Ordinal(9)] 
		[RED("postReturnSignalTimeDelay")] 
		public CFloat PostReturnSignalTimeDelay
		{
			get => GetProperty(ref _postReturnSignalTimeDelay);
			set => SetProperty(ref _postReturnSignalTimeDelay, value);
		}

		[Ordinal(10)] 
		[RED("postInterruptSignalFactCondition")] 
		public CHandle<scnInterruptFactConditionType> PostInterruptSignalFactCondition
		{
			get => GetProperty(ref _postInterruptSignalFactCondition);
			set => SetProperty(ref _postInterruptSignalFactCondition, value);
		}

		[Ordinal(11)] 
		[RED("postReturnSignalFactCondition")] 
		public CHandle<scnInterruptFactConditionType> PostReturnSignalFactCondition
		{
			get => GetProperty(ref _postReturnSignalFactCondition);
			set => SetProperty(ref _postReturnSignalFactCondition, value);
		}

		[Ordinal(12)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetProperty(ref _interruptConditions);
			set => SetProperty(ref _interruptConditions, value);
		}

		[Ordinal(13)] 
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get => GetProperty(ref _returnConditions);
			set => SetProperty(ref _returnConditions, value);
		}

		public scnInterruptionScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
