using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LODBegin : animAnimNode_OnePoseInput
	{
		private CUInt32 _levelOfDetail;

		[Ordinal(12)] 
		[RED("levelOfDetail")] 
		public CUInt32 LevelOfDetail
		{
			get => GetProperty(ref _levelOfDetail);
			set => SetProperty(ref _levelOfDetail, value);
		}

		public animAnimNode_LODBegin(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
