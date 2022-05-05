using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CoverState : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("debugVar")] 
		public CBool DebugVar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_CoverState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
