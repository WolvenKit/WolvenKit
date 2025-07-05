using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_VectorLatch : animAnimNode_VectorValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_VectorLatch()
		{
			Id = uint.MaxValue;
			Input = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
