using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStimuli_ConditionType : questISensesConditionType
	{
		private gameEntityReference _instigatorRef;
		private CBool _isPlayerInstigator;
		private gameEntityReference _targetRef;
		private CEnum<gamedataStimType> _type;

		[Ordinal(0)] 
		[RED("instigatorRef")] 
		public gameEntityReference InstigatorRef
		{
			get => GetProperty(ref _instigatorRef);
			set => SetProperty(ref _instigatorRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayerInstigator")] 
		public CBool IsPlayerInstigator
		{
			get => GetProperty(ref _isPlayerInstigator);
			set => SetProperty(ref _isPlayerInstigator, value);
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataStimType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
