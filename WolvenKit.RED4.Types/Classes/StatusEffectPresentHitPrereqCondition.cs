using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _checkType;
		private CName _statusEffectParam;
		private CName _tag;
		private CName _objectToCheck;

		[Ordinal(1)] 
		[RED("checkType")] 
		public CName CheckType
		{
			get => GetProperty(ref _checkType);
			set => SetProperty(ref _checkType, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectParam")] 
		public CName StatusEffectParam
		{
			get => GetProperty(ref _statusEffectParam);
			set => SetProperty(ref _statusEffectParam, value);
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(4)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetProperty(ref _objectToCheck);
			set => SetProperty(ref _objectToCheck, value);
		}

		public StatusEffectPresentHitPrereqCondition()
		{
			_objectToCheck = "Target";
		}
	}
}
