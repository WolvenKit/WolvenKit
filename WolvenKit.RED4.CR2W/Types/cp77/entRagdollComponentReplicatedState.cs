using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollComponentReplicatedState : netIComponentState
	{
		private CArray<Transform> _transforms;
		private CBool _isSleeping;

		[Ordinal(2)] 
		[RED("transforms")] 
		public CArray<Transform> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}

		[Ordinal(3)] 
		[RED("isSleeping")] 
		public CBool IsSleeping
		{
			get => GetProperty(ref _isSleeping);
			set => SetProperty(ref _isSleeping, value);
		}

		public entRagdollComponentReplicatedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
