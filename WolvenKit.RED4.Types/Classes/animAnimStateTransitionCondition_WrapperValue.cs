using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_WrapperValue : animIAnimStateTransitionCondition
	{
		private CName _wrapperName;
		private CBool _checkIfWrapperIsSet;

		[Ordinal(0)] 
		[RED("wrapperName")] 
		public CName WrapperName
		{
			get => GetProperty(ref _wrapperName);
			set => SetProperty(ref _wrapperName, value);
		}

		[Ordinal(1)] 
		[RED("checkIfWrapperIsSet")] 
		public CBool CheckIfWrapperIsSet
		{
			get => GetProperty(ref _checkIfWrapperIsSet);
			set => SetProperty(ref _checkIfWrapperIsSet, value);
		}

		public animAnimStateTransitionCondition_WrapperValue()
		{
			_checkIfWrapperIsSet = true;
		}
	}
}
