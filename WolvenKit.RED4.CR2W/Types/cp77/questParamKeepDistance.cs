using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questParamKeepDistance : ISerializable
	{
		private CHandle<questUniversalRef> _companionTargetRef;
		private CFloat _distance;

		[Ordinal(0)] 
		[RED("companionTargetRef")] 
		public CHandle<questUniversalRef> CompanionTargetRef
		{
			get => GetProperty(ref _companionTargetRef);
			set => SetProperty(ref _companionTargetRef, value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		public questParamKeepDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
