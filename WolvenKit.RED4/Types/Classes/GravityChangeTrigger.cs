using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GravityChangeTrigger : gameObject
	{
		[Ordinal(36)] 
		[RED("gravityType")] 
		public CEnum<EGravityType> GravityType
		{
			get => GetPropertyValue<CEnum<EGravityType>>();
			set => SetPropertyValue<CEnum<EGravityType>>(value);
		}

		[Ordinal(37)] 
		[RED("regularStateMachineName")] 
		public CName RegularStateMachineName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("lowGravityStateMachineName")] 
		public CName LowGravityStateMachineName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GravityChangeTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
