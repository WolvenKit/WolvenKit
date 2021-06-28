using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDesiredSlotsCountInfo : CVariable
	{
		private CFloat _siredSlotsCount;
		private CFloat _nCoeff;

		[Ordinal(0)] 
		[RED("siredSlotsCount")] 
		public CFloat SiredSlotsCount
		{
			get => GetProperty(ref _siredSlotsCount);
			set => SetProperty(ref _siredSlotsCount, value);
		}

		[Ordinal(1)] 
		[RED("nCoeff")] 
		public CFloat NCoeff
		{
			get => GetProperty(ref _nCoeff);
			set => SetProperty(ref _nCoeff, value);
		}

		public worldDesiredSlotsCountInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
