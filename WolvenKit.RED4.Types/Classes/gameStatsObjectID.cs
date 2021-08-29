using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatsObjectID : RedBaseClass
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
	}
}
