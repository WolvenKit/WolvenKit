using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InstigatorTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _instigatorType;

		[Ordinal(1)] 
		[RED("instigatorType")] 
		public CName InstigatorType
		{
			get => GetProperty(ref _instigatorType);
			set => SetProperty(ref _instigatorType, value);
		}
	}
}
