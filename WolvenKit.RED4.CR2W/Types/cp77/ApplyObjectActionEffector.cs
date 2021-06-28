using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyObjectActionEffector : gameEffector
	{
		private TweakDBID _actionID;
		private CBool _triggered;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get => GetProperty(ref _triggered);
			set => SetProperty(ref _triggered, value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		public ApplyObjectActionEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
