using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LastHitDataEvent : redEvent
	{
		private CHandle<HitReactionBehaviorData> _hitReactionBehaviorData;

		[Ordinal(0)] 
		[RED("hitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> HitReactionBehaviorData
		{
			get
			{
				if (_hitReactionBehaviorData == null)
				{
					_hitReactionBehaviorData = (CHandle<HitReactionBehaviorData>) CR2WTypeManager.Create("handle:HitReactionBehaviorData", "hitReactionBehaviorData", cr2w, this);
				}
				return _hitReactionBehaviorData;
			}
			set
			{
				if (_hitReactionBehaviorData == value)
				{
					return;
				}
				_hitReactionBehaviorData = value;
				PropertySet(this);
			}
		}

		public LastHitDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
