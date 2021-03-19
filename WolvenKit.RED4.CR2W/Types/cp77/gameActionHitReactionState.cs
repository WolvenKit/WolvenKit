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
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		public gameActionHitReactionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
