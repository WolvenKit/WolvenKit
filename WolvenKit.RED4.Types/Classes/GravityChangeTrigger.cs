using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GravityChangeTrigger : gameObject
	{
		[Ordinal(40)] 
		[RED("gravityType")] 
		public CEnum<EGravityType> GravityType
		{
			get => GetPropertyValue<CEnum<EGravityType>>();
			set => SetPropertyValue<CEnum<EGravityType>>(value);
		}

		[Ordinal(41)] 
		[RED("regularStateMachineName")] 
		public CName RegularStateMachineName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("lowGravityStateMachineName")] 
		public CName LowGravityStateMachineName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GravityChangeTrigger()
		{
			RegularStateMachineName = "Locomotion";
			LowGravityStateMachineName = "LocomotionLowGravity";
		}
	}
}
