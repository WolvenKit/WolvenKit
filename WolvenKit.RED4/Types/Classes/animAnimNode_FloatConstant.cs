using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatConstant : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_FloatConstant()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
