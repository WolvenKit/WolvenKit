using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Join : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animPoseLink Input
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_Join()
		{
			Id = uint.MaxValue;
			Input = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
