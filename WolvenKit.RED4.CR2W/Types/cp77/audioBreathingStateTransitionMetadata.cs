using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBreathingStateTransitionMetadata : audioAudioMetadata
	{
		private CArray<CName> _fromNames;
		private CName _toName;
		private CName _transitionStateName;
		private CEnum<audioBreathingTransitionType> _conditionType;
		private CEnum<audioBreathingTransitionComparator> _conditionComparator;
		private CName _value;
		private CArray<CEnum<audiobreathingEventTag>> _eventTags;
		private CBool _isImmediate;

		[Ordinal(1)] 
		[RED("fromNames")] 
		public CArray<CName> FromNames
		{
			get => GetProperty(ref _fromNames);
			set => SetProperty(ref _fromNames, value);
		}

		[Ordinal(2)] 
		[RED("toName")] 
		public CName ToName
		{
			get => GetProperty(ref _toName);
			set => SetProperty(ref _toName, value);
		}

		[Ordinal(3)] 
		[RED("transitionStateName")] 
		public CName TransitionStateName
		{
			get => GetProperty(ref _transitionStateName);
			set => SetProperty(ref _transitionStateName, value);
		}

		[Ordinal(4)] 
		[RED("conditionType")] 
		public CEnum<audioBreathingTransitionType> ConditionType
		{
			get => GetProperty(ref _conditionType);
			set => SetProperty(ref _conditionType, value);
		}

		[Ordinal(5)] 
		[RED("conditionComparator")] 
		public CEnum<audioBreathingTransitionComparator> ConditionComparator
		{
			get => GetProperty(ref _conditionComparator);
			set => SetProperty(ref _conditionComparator, value);
		}

		[Ordinal(6)] 
		[RED("value")] 
		public CName Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(7)] 
		[RED("eventTags")] 
		public CArray<CEnum<audiobreathingEventTag>> EventTags
		{
			get => GetProperty(ref _eventTags);
			set => SetProperty(ref _eventTags, value);
		}

		[Ordinal(8)] 
		[RED("isImmediate")] 
		public CBool IsImmediate
		{
			get => GetProperty(ref _isImmediate);
			set => SetProperty(ref _isImmediate, value);
		}

		public audioBreathingStateTransitionMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
