using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Stage : animAnimNode_Container
	{
		[Ordinal(12)] 
		[RED("inputPoses")] 
		public CArray<animPoseLink> InputPoses
		{
			get => GetPropertyValue<CArray<animPoseLink>>();
			set => SetPropertyValue<CArray<animPoseLink>>(value);
		}

		public animAnimNode_Stage()
		{
			Id = uint.MaxValue;
			Nodes = new();
			InputPoses = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
