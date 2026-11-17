using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionConstant : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] 
		[RED("value")] 
		public Quaternion Value
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animAnimNode_QuaternionConstant()
		{
			Id = uint.MaxValue;
			Value = new Quaternion();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
