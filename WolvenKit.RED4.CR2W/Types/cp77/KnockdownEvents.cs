using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KnockdownEvents : StatusEffectEvents
	{
		private Vector4 _cachedPlayerVelocity;
		private Vector4 _secondaryKnockdownDir;
		private CFloat _secondaryKnockdownTimer;
		private CBool _playedImpactAnim;
		private CBool _frictionForceApplied;

		[Ordinal(3)] 
		[RED("cachedPlayerVelocity")] 
		public Vector4 CachedPlayerVelocity
		{
			get => GetProperty(ref _cachedPlayerVelocity);
			set => SetProperty(ref _cachedPlayerVelocity, value);
		}

		[Ordinal(4)] 
		[RED("secondaryKnockdownDir")] 
		public Vector4 SecondaryKnockdownDir
		{
			get => GetProperty(ref _secondaryKnockdownDir);
			set => SetProperty(ref _secondaryKnockdownDir, value);
		}

		[Ordinal(5)] 
		[RED("secondaryKnockdownTimer")] 
		public CFloat SecondaryKnockdownTimer
		{
			get => GetProperty(ref _secondaryKnockdownTimer);
			set => SetProperty(ref _secondaryKnockdownTimer, value);
		}

		[Ordinal(6)] 
		[RED("playedImpactAnim")] 
		public CBool PlayedImpactAnim
		{
			get => GetProperty(ref _playedImpactAnim);
			set => SetProperty(ref _playedImpactAnim, value);
		}

		[Ordinal(7)] 
		[RED("frictionForceApplied")] 
		public CBool FrictionForceApplied
		{
			get => GetProperty(ref _frictionForceApplied);
			set => SetProperty(ref _frictionForceApplied, value);
		}

		public KnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
