using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatExpectationInvalid : AIAIEvent
	{
		private wCHandle<entEntity> _owner;
		private wCHandle<entEntity> _threat;
		private CUInt32 _threatId;

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("threat")] 
		public wCHandle<entEntity> Threat
		{
			get => GetProperty(ref _threat);
			set => SetProperty(ref _threat, value);
		}

		[Ordinal(4)] 
		[RED("threatId")] 
		public CUInt32 ThreatId
		{
			get => GetProperty(ref _threatId);
			set => SetProperty(ref _threatId, value);
		}

		public AIThreatExpectationInvalid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
