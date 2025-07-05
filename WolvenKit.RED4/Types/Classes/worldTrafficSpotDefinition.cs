using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class worldTrafficSpotDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<worldTrafficSpotDirection> Direction
		{
			get => GetPropertyValue<CEnum<worldTrafficSpotDirection>>();
			set => SetPropertyValue<CEnum<worldTrafficSpotDirection>>(value);
		}

		public worldTrafficSpotDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
