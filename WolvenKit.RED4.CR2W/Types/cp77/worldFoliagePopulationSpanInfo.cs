using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePopulationSpanInfo : CVariable
	{
		private CUInt32 _stancesBegin;
		private CUInt32 _cketBegin;
		private CUInt32 _stancesCount;
		private CUInt32 _cketCount;

		[Ordinal(0)] 
		[RED("stancesBegin")] 
		public CUInt32 StancesBegin
		{
			get => GetProperty(ref _stancesBegin);
			set => SetProperty(ref _stancesBegin, value);
		}

		[Ordinal(1)] 
		[RED("cketBegin")] 
		public CUInt32 CketBegin
		{
			get => GetProperty(ref _cketBegin);
			set => SetProperty(ref _cketBegin, value);
		}

		[Ordinal(2)] 
		[RED("stancesCount")] 
		public CUInt32 StancesCount
		{
			get => GetProperty(ref _stancesCount);
			set => SetProperty(ref _stancesCount, value);
		}

		[Ordinal(3)] 
		[RED("cketCount")] 
		public CUInt32 CketCount
		{
			get => GetProperty(ref _cketCount);
			set => SetProperty(ref _cketCount, value);
		}

		public worldFoliagePopulationSpanInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
