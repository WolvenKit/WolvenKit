using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetTargetHealthEffector : gameEffector
	{
		private CFloat _healthValueToSet;

		[Ordinal(0)] 
		[RED("healthValueToSet")] 
		public CFloat HealthValueToSet
		{
			get => GetProperty(ref _healthValueToSet);
			set => SetProperty(ref _healthValueToSet, value);
		}
	}
}
