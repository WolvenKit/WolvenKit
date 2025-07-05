using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkAnimDecorator : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("Fallback")] 
		public animPoseLink Fallback
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_SkAnimDecorator()
		{
			Fallback = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
