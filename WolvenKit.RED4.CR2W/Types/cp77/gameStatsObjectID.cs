using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsObjectID : CVariable
	{
		private CUInt64 _entityHash;
		private CEnum<gameStatIDType> _idType;

		[Ordinal(0)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get => GetProperty(ref _entityHash);
			set => SetProperty(ref _entityHash, value);
		}

		[Ordinal(1)] 
		[RED("idType")] 
		public CEnum<gameStatIDType> IdType
		{
			get => GetProperty(ref _idType);
			set => SetProperty(ref _idType, value);
		}

		public gameStatsObjectID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
