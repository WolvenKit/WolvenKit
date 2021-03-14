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
			get
			{
				if (_cachedPlayerVelocity == null)
				{
					_cachedPlayerVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "cachedPlayerVelocity", cr2w, this);
				}
				return _cachedPlayerVelocity;
			}
			set
			{
				if (_cachedPlayerVelocity == value)
				{
					return;
				}
				_cachedPlayerVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("secondaryKnockdownDir")] 
		public Vector4 SecondaryKnockdownDir
		{
			get
			{
				if (_secondaryKnockdownDir == null)
				{
					_secondaryKnockdownDir = (Vector4) CR2WTypeManager.Create("Vector4", "secondaryKnockdownDir", cr2w, this);
				}
				return _secondaryKnockdownDir;
			}
			set
			{
				if (_secondaryKnockdownDir == value)
				{
					return;
				}
				_secondaryKnockdownDir = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("secondaryKnockdownTimer")] 
		public CFloat SecondaryKnockdownTimer
		{
			get
			{
				if (_secondaryKnockdownTimer == null)
				{
					_secondaryKnockdownTimer = (CFloat) CR2WTypeManager.Create("Float", "secondaryKnockdownTimer", cr2w, this);
				}
				return _secondaryKnockdownTimer;
			}
			set
			{
				if (_secondaryKnockdownTimer == value)
				{
					return;
				}
				_secondaryKnockdownTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playedImpactAnim")] 
		public CBool PlayedImpactAnim
		{
			get
			{
				if (_playedImpactAnim == null)
				{
					_playedImpactAnim = (CBool) CR2WTypeManager.Create("Bool", "playedImpactAnim", cr2w, this);
				}
				return _playedImpactAnim;
			}
			set
			{
				if (_playedImpactAnim == value)
				{
					return;
				}
				_playedImpactAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("frictionForceApplied")] 
		public CBool FrictionForceApplied
		{
			get
			{
				if (_frictionForceApplied == null)
				{
					_frictionForceApplied = (CBool) CR2WTypeManager.Create("Bool", "frictionForceApplied", cr2w, this);
				}
				return _frictionForceApplied;
			}
			set
			{
				if (_frictionForceApplied == value)
				{
					return;
				}
				_frictionForceApplied = value;
				PropertySet(this);
			}
		}

		public KnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
