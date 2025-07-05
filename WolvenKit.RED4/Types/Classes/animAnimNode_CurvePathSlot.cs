using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_CurvePathSlot : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animPoseLink Input
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_CurvePathSlot()
		{
			Id = uint.MaxValue;
			Input = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
