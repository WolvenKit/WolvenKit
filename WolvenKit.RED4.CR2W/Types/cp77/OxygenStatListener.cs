using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OxygenStatListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _ownerPuppet;
		private CHandle<worldEffectBlackboard> _oxygenVfxBlackboard;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("oxygenVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> OxygenVfxBlackboard
		{
			get => GetProperty(ref _oxygenVfxBlackboard);
			set => SetProperty(ref _oxygenVfxBlackboard, value);
		}

		public OxygenStatListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
