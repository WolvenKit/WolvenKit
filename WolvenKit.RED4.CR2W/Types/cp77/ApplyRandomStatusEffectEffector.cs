using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyRandomStatusEffectEffector : gameEffector
	{
		private wCHandle<gameObject> _target;
		private CString _applicationTarget;
		private CArray<TweakDBID> _effects;
		private TweakDBID _appliedEffect;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
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

		public ApplyRandomStatusEffectEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
