using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WallScreenControllerPS : TVControllerPS
	{
		[Ordinal(114)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WallScreenControllerPS()
		{
			TweakDBRecord = 78369534372;
			TweakDBDescriptionRecord = 131860853415;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
