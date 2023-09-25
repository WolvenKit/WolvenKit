using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("wasOverloaded")] 
		public CBool WasOverloaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NetrunnerChairControllerPS()
		{
			DeviceName = "LocKey#17884";
			TweakDBRecord = "Devices.NetrunnerChair";
			TweakDBDescriptionRecord = 149097016357;
			KillDelay = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
