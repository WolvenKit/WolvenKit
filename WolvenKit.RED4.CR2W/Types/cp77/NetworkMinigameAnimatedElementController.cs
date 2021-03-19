using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameAnimatedElementController : NetworkMinigameElementController
	{
		private CName _onConsumeAnimation;
		private CName _onSetContentAnimation;
		private CName _onHighlightOnAnimation;
		private CName _onHighlightOffAnimation;

		[Ordinal(12)] 
		[RED("onConsumeAnimation")] 
		public CName OnConsumeAnimation
		{
			get => GetProperty(ref _onConsumeAnimation);
			set => SetProperty(ref _onConsumeAnimation, value);
		}

		[Ordinal(13)] 
		[RED("onSetContentAnimation")] 
		public CName OnSetContentAnimation
		{
			get => GetProperty(ref _onSetContentAnimation);
			set => SetProperty(ref _onSetContentAnimation, value);
		}

		[Ordinal(14)] 
		[RED("onHighlightOnAnimation")] 
		public CName OnHighlightOnAnimation
		{
			get => GetProperty(ref _onHighlightOnAnimation);
			set => SetProperty(ref _onHighlightOnAnimation, value);
		}

		[Ordinal(15)] 
		[RED("onHighlightOffAnimation")] 
		public CName OnHighlightOffAnimation
		{
			get => GetProperty(ref _onHighlightOffAnimation);
			set => SetProperty(ref _onHighlightOffAnimation, value);
		}

		public NetworkMinigameAnimatedElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
