using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionConstant : animAnimNode_QuaternionValue
	{
		[Ordinal(11)] 
		[RED("value")] 
		public Quaternion Value
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animAnimNode_QuaternionConstant()
		{
			Id = 4294967295;
			Value = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
