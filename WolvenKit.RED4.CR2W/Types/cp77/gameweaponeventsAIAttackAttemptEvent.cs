using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsAIAttackAttemptEvent : redEvent
	{
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _target;
		private CBool _isWindUp;
		private CEnum<gameEContinuousMode> _continuousMode;
		private CFloat _minimumOpacity;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("isWindUp")] 
		public CBool IsWindUp
		{
			get => GetProperty(ref _isWindUp);
			set => SetProperty(ref _isWindUp, value);
		}

		[Ordinal(3)] 
		[RED("continuousMode")] 
		public CEnum<gameEContinuousMode> ContinuousMode
		{
			get => GetProperty(ref _continuousMode);
			set => SetProperty(ref _continuousMode, value);
		}

		[Ordinal(4)] 
		[RED("minimumOpacity")] 
		public CFloat MinimumOpacity
		{
			get => GetProperty(ref _minimumOpacity);
			set => SetProperty(ref _minimumOpacity, value);
		}

		public gameweaponeventsAIAttackAttemptEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
