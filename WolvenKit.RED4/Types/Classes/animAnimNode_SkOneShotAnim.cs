using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkOneShotAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(31)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_SkOneShotAnim()
		{
			Input = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
