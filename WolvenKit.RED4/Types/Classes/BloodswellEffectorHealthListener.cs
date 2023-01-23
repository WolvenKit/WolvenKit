using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloodswellEffectorHealthListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CHandle<BloodswellEffector> Effector
		{
			get => GetPropertyValue<CHandle<BloodswellEffector>>();
			set => SetPropertyValue<CHandle<BloodswellEffector>>(value);
		}

		public BloodswellEffectorHealthListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
