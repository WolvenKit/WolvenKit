using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyEffectorEffector : gameEffector
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

		public ApplyEffectorEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
