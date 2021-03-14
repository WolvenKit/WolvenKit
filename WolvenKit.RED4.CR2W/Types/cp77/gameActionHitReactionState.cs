using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionHitReactionState : gameActionReplicatedState
	{
		private CHandle<animAnimFeature_HitReactionsData> _animFeature;

		[Ordinal(5)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<animAnimFeature_HitReactionsData>) CR2WTypeManager.Create("handle:animAnimFeature_HitReactionsData", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		public gameActionHitReactionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
