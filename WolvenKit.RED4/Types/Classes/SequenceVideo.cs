using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SequenceVideo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(1)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SequenceVideo()
		{
			VideoPath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
