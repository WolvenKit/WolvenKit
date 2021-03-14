using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitReactionBehaviorData : IScriptable
	{
		private CEnum<animHitReactionType> _hitReactionType;
		private CFloat _hitReactionActivationTimeStamp;
		private CFloat _hitReactionDuration;

		[Ordinal(0)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get
			{
				if (_hitReactionType == null)
				{
					_hitReactionType = (CEnum<animHitReactionType>) CR2WTypeManager.Create("animHitReactionType", "hitReactionType", cr2w, this);
				}
				return _hitReactionType;
			}
			set
			{
				if (_hitReactionType == value)
				{
					return;
				}
				_hitReactionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitReactionActivationTimeStamp")] 
		public CFloat HitReactionActivationTimeStamp
		{
			get
			{
				if (_hitReactionActivationTimeStamp == null)
				{
					_hitReactionActivationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "hitReactionActivationTimeStamp", cr2w, this);
				}
				return _hitReactionActivationTimeStamp;
			}
			set
			{
				if (_hitReactionActivationTimeStamp == value)
				{
					return;
				}
				_hitReactionActivationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitReactionDuration")] 
		public CFloat HitReactionDuration
		{
			get
			{
				if (_hitReactionDuration == null)
				{
					_hitReactionDuration = (CFloat) CR2WTypeManager.Create("Float", "hitReactionDuration", cr2w, this);
				}
				return _hitReactionDuration;
			}
			set
			{
				if (_hitReactionDuration == value)
				{
					return;
				}
				_hitReactionDuration = value;
				PropertySet(this);
			}
		}

		public HitReactionBehaviorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
