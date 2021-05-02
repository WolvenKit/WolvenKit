using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorGameController : gameuiHUDGameController
	{
		private CUInt8 _maxVisibleParts;

		[Ordinal(9)] 
		[RED("maxVisibleParts")] 
		public CUInt8 MaxVisibleParts
		{
			get => GetProperty(ref _maxVisibleParts);
			set => SetProperty(ref _maxVisibleParts, value);
		}

		public gameuiDamageIndicatorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
