using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public NetrunnerChairControllerPS()
		{
			DeviceName = "LocKey#17884";
			TweakDBRecord = new() { Value = 95884201829 };
			TweakDBDescriptionRecord = new() { Value = 149097016357 };
			KillDelay = 1.000000F;
		}
	}
}
