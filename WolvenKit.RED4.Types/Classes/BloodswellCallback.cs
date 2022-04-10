using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloodswellCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("bloodswellEffector")] 
		public CHandle<BloodswellEffector> BloodswellEffector
		{
			get => GetPropertyValue<CHandle<BloodswellEffector>>();
			set => SetPropertyValue<CHandle<BloodswellEffector>>(value);
		}

		public BloodswellCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
