using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionResource : CResource
	{
		private CHandle<worldTrafficNullAreaCollisionData> _nullAreasCollisionData;
		private CHandle<worldTrafficNullAreaDynamicBlockadeData> _nullAreaBlockadeData;

		[Ordinal(1)] 
		[RED("nullAreasCollisionData")] 
		public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData
		{
			get => GetProperty(ref _nullAreasCollisionData);
			set => SetProperty(ref _nullAreasCollisionData, value);
		}

		[Ordinal(2)] 
		[RED("nullAreaBlockadeData")] 
		public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData
		{
			get => GetProperty(ref _nullAreaBlockadeData);
			set => SetProperty(ref _nullAreaBlockadeData, value);
		}

		public worldTrafficNullAreaCollisionResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
