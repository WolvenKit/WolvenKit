using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeResourcePoolListener : gameScriptStatPoolsListener
	{
		private wCHandle<CrosshairGameController_Melee> _meleeCrosshair;

		[Ordinal(0)] 
		[RED("meleeCrosshair")] 
		public wCHandle<CrosshairGameController_Melee> MeleeCrosshair
		{
			get => GetProperty(ref _meleeCrosshair);
			set => SetProperty(ref _meleeCrosshair, value);
		}

		public MeleeResourcePoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
