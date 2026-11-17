using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendSpace : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("inputLinks")] 
		public CArray<animFloatLink> InputLinks
		{
			get => GetPropertyValue<CArray<animFloatLink>>();
			set => SetPropertyValue<CArray<animFloatLink>>(value);
		}

		[Ordinal(2)] 
		[RED("blendSpace")] 
		public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace
		{
			get => GetPropertyValue<animAnimNode_BlendSpace_InternalsBlendSpace>();
			set => SetPropertyValue<animAnimNode_BlendSpace_InternalsBlendSpace>(value);
		}

		[Ordinal(3)] 
		[RED("progressLink")] 
		public animFloatLink ProgressLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(4)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_BlendSpace()
		{
			Id = uint.MaxValue;
			InputLinks = new() { new animFloatLink() };
			BlendSpace = new animAnimNode_BlendSpace_InternalsBlendSpace();
			ProgressLink = new animFloatLink();
			IsLooped = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
