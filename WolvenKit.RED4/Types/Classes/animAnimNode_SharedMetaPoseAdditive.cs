using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SharedMetaPoseAdditive : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(13)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get => GetPropertyValue<CEnum<animEAnimGraphAdditiveType>>();
			set => SetPropertyValue<CEnum<animEAnimGraphAdditiveType>>(value);
		}

		[Ordinal(14)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get => GetPropertyValue<CEnum<animEBlendTracksMode>>();
			set => SetPropertyValue<CEnum<animEBlendTracksMode>>(value);
		}

		[Ordinal(15)] 
		[RED("convertParentPoseToAdditive")] 
		public CBool ConvertParentPoseToAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_SharedMetaPoseAdditive()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			WeightLink = new animFloatLink();
			BlendTracks = Enums.animEBlendTracksMode.AGBT_Add;
			ConvertParentPoseToAdditive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
