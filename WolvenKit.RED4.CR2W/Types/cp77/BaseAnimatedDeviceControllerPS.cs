using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isActive;
		private CBool _hasInteraction;
		private CBool _randomizeAnimationTime;
		private TweakDBID _nameForActivation;
		private TweakDBID _nameForDeactivation;

		[Ordinal(104)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(105)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetProperty(ref _hasInteraction);
			set => SetProperty(ref _hasInteraction, value);
		}

		[Ordinal(106)] 
		[RED("randomizeAnimationTime")] 
		public CBool RandomizeAnimationTime
		{
			get => GetProperty(ref _randomizeAnimationTime);
			set => SetProperty(ref _randomizeAnimationTime, value);
		}

		[Ordinal(107)] 
		[RED("nameForActivation")] 
		public TweakDBID NameForActivation
		{
			get => GetProperty(ref _nameForActivation);
			set => SetProperty(ref _nameForActivation, value);
		}

		[Ordinal(108)] 
		[RED("nameForDeactivation")] 
		public TweakDBID NameForDeactivation
		{
			get => GetProperty(ref _nameForDeactivation);
			set => SetProperty(ref _nameForDeactivation, value);
		}

		public BaseAnimatedDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
