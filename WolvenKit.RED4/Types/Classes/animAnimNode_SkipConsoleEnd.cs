using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkipConsoleEnd : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_SkipConsoleEnd()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
