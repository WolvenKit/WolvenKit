using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BlendSpace : animAnimNode_Base
	{
		private CArray<animFloatLink> _inputLinks;
		private animAnimNode_BlendSpace_InternalsBlendSpace _blendSpace;
		private animFloatLink _progressLink;
		private CBool _fireAnimEndEvent;
		private CName _animEndEventName;
		private CBool _isLooped;

		[Ordinal(11)] 
		[RED("inputLinks")] 
		public CArray<animFloatLink> InputLinks
		{
			get => GetProperty(ref _inputLinks);
			set => SetProperty(ref _inputLinks, value);
		}

		[Ordinal(12)] 
		[RED("blendSpace")] 
		public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace
		{
			get => GetProperty(ref _blendSpace);
			set => SetProperty(ref _blendSpace, value);
		}

		[Ordinal(13)] 
		[RED("progressLink")] 
		public animFloatLink ProgressLink
		{
			get => GetProperty(ref _progressLink);
			set => SetProperty(ref _progressLink, value);
		}

		[Ordinal(14)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get => GetProperty(ref _fireAnimEndEvent);
			set => SetProperty(ref _fireAnimEndEvent, value);
		}

		[Ordinal(15)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetProperty(ref _animEndEventName);
			set => SetProperty(ref _animEndEventName, value);
		}

		[Ordinal(16)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}
	}
}
