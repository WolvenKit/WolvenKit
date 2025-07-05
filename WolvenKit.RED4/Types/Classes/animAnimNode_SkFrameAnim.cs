using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkFrameAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("progressLink")] 
		public animFloatLink ProgressLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(31)] 
		[RED("timeLink")] 
		public animFloatLink TimeLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(32)] 
		[RED("frameLink")] 
		public animFloatLink FrameLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(33)] 
		[RED("fireAnimEndOnceOnAnimEnd")] 
		public CBool FireAnimEndOnceOnAnimEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_SkFrameAnim()
		{
			ProgressLink = new animFloatLink();
			TimeLink = new animFloatLink();
			FrameLink = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
