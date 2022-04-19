using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageDigitUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("controllerIndex")] 
		public CInt32 ControllerIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public DamageDigitUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
