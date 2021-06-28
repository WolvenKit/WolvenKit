using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronChargeController : ChargeLogicController
	{
		private wCHandle<inkImageWidget> _chargeBar;

		[Ordinal(1)] 
		[RED("chargeBar")] 
		public wCHandle<inkImageWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		public megatronChargeController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
