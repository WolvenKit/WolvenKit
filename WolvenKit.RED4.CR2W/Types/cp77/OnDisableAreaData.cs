using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnDisableAreaData : CVariable
	{
		private gamePersistentID _agent;
		private CArray<CHandle<SecurityAreaControllerPS>> _remainingAreas;

		[Ordinal(0)] 
		[RED("agent")] 
		public gamePersistentID Agent
		{
			get => GetProperty(ref _agent);
			set => SetProperty(ref _agent, value);
		}

		[Ordinal(1)] 
		[RED("remainingAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> RemainingAreas
		{
			get => GetProperty(ref _remainingAreas);
			set => SetProperty(ref _remainingAreas, value);
		}

		public OnDisableAreaData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
