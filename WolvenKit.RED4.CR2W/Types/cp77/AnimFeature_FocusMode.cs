using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_FocusMode : animAnimFeature
	{
		private CBool _isFocusModeActive;

		[Ordinal(0)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetProperty(ref _isFocusModeActive);
			set => SetProperty(ref _isFocusModeActive, value);
		}

		public AnimFeature_FocusMode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
