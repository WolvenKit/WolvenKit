using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AOEAreaControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get => GetPropertyValue<AOEAreaSetup>();
			set => SetPropertyValue<AOEAreaSetup>(value);
		}

		public AOEAreaControllerPS()
		{
			DeviceName = "LocKey#188";
			TweakDBRecord = new() { Value = 69554440257 };
			TweakDBDescriptionRecord = new() { Value = 121659857626 };
			AOEAreaSetup = new() { Duration = -1.000000F };
		}
	}
}
