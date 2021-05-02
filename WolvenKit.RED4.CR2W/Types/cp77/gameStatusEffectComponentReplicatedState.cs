using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentReplicatedState : netIComponentState
	{
		private CArray<gameStatusEffectReplicatedInfo> _replicatedInfo;

		[Ordinal(2)] 
		[RED("replicatedInfo")] 
		public CArray<gameStatusEffectReplicatedInfo> ReplicatedInfo
		{
			get => GetProperty(ref _replicatedInfo);
			set => SetProperty(ref _replicatedInfo, value);
		}

		public gameStatusEffectComponentReplicatedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
