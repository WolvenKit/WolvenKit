using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyRandomStatusEffectEffector : gameEffector
	{
		private entEntityID _targetEntityID;
		private CString _applicationTarget;
		private CArray<TweakDBID> _effects;
		private TweakDBID _appliedEffect;

		[Ordinal(0)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetProperty(ref _targetEntityID);
			set => SetProperty(ref _targetEntityID, value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<TweakDBID> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		[Ordinal(3)] 
		[RED("appliedEffect")] 
		public TweakDBID AppliedEffect
		{
			get => GetProperty(ref _appliedEffect);
			set => SetProperty(ref _appliedEffect, value);
		}
	}
}
