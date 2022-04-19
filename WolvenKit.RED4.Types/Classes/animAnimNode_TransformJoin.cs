using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TransformJoin : animAnimNode_TransformValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animTransformLink Input
		{
			get => GetPropertyValue<animTransformLink>();
			set => SetPropertyValue<animTransformLink>(value);
		}

		public animAnimNode_TransformJoin()
		{
			Id = 4294967295;
			Input = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
