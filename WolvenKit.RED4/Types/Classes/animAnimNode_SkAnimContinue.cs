using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		[Ordinal(18)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(19)] 
		[RED("popSafeCutTag")] 
		public CName PopSafeCutTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_SkAnimContinue()
		{
			Input = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
