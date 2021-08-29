using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyEffectorEffector : gameEffector
	{
		private entEntityID _target;
		private CString _applicationTarget;
		private TweakDBID _effectorToApply;

		[Ordinal(0)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(2)] 
		[RED("effectorToApply")] 
		public TweakDBID EffectorToApply
		{
			get => GetProperty(ref _effectorToApply);
			set => SetProperty(ref _effectorToApply, value);
		}
	}
}
