using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideClearNode : questIAudioNodeType
	{
		private CBool _resetGlobalOverride;
		private CBool _resetActorsOverride;

		[Ordinal(0)] 
		[RED("resetGlobalOverride")] 
		public CBool ResetGlobalOverride
		{
			get => GetProperty(ref _resetGlobalOverride);
			set => SetProperty(ref _resetGlobalOverride, value);
		}

		[Ordinal(1)] 
		[RED("resetActorsOverride")] 
		public CBool ResetActorsOverride
		{
			get => GetProperty(ref _resetActorsOverride);
			set => SetProperty(ref _resetActorsOverride, value);
		}

		public questAnimationEventsOverrideClearNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
