using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SafeAction : animAnimFeature
	{
		private CBool _triggerHeld;
		private CBool _inCover;
		private CFloat _safeActionDuration;

		[Ordinal(0)] 
		[RED("triggerHeld")] 
		public CBool TriggerHeld
		{
			get => GetProperty(ref _triggerHeld);
			set => SetProperty(ref _triggerHeld, value);
		}

		[Ordinal(1)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetProperty(ref _inCover);
			set => SetProperty(ref _inCover, value);
		}

		[Ordinal(2)] 
		[RED("safeActionDuration")] 
		public CFloat SafeActionDuration
		{
			get => GetProperty(ref _safeActionDuration);
			set => SetProperty(ref _safeActionDuration, value);
		}

		public AnimFeature_SafeAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
