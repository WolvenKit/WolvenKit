using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowerFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private CFloat _lastResultTimestamp;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetProperty(ref _outPositionArgument);
			set => SetProperty(ref _outPositionArgument, value);
		}

		[Ordinal(2)] 
		[RED("lastResultTimestamp")] 
		public CFloat LastResultTimestamp
		{
			get => GetProperty(ref _lastResultTimestamp);
			set => SetProperty(ref _lastResultTimestamp, value);
		}

		public FollowerFindTeleportPositionAroundTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
