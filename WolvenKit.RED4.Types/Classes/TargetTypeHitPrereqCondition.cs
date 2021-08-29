using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _targetType;

		[Ordinal(1)] 
		[RED("targetType")] 
		public CName TargetType
		{
			get => GetProperty(ref _targetType);
			set => SetProperty(ref _targetType, value);
		}
	}
}
