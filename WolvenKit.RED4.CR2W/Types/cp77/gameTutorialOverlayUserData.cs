using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTutorialOverlayUserData : inkUserData
	{
		private CBool _hideOnInput;
		private CUInt32 _overlayId;

		[Ordinal(0)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetProperty(ref _hideOnInput);
			set => SetProperty(ref _hideOnInput, value);
		}

		[Ordinal(1)] 
		[RED("overlayId")] 
		public CUInt32 OverlayId
		{
			get => GetProperty(ref _overlayId);
			set => SetProperty(ref _overlayId, value);
		}

		public gameTutorialOverlayUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
