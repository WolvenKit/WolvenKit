using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class animAnimNode_OnePoseInput : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_OnePoseInput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
