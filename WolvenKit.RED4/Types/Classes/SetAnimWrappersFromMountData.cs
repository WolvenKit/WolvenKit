using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAnimWrappersFromMountData : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public SetAnimWrappersFromMountData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
