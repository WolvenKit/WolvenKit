using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableQuaternion : animAnimVariable
	{
		[Ordinal(2)] 
		[RED("roll")] 
		public CFloat Roll
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("default")] 
		public Quaternion Default
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animAnimVariableQuaternion()
		{
			Default = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
