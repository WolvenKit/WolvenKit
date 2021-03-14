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
			get
			{
				if (_meleeCrosshair == null)
				{
					_meleeCrosshair = (wCHandle<CrosshairGameController_Melee>) CR2WTypeManager.Create("whandle:CrosshairGameController_Melee", "meleeCrosshair", cr2w, this);
				}
				return _meleeCrosshair;
			}
			set
			{
				if (_meleeCrosshair == value)
				{
					return;
				}
				_meleeCrosshair = value;
				PropertySet(this);
			}
		}

		public MeleeResourcePoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
