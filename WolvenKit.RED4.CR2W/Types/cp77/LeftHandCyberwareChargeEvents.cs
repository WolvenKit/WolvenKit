using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareChargeEvents : LeftHandCyberwareEventsTransition
	{
		private CHandle<gameweaponAnimFeature_AimPlayer> _chargeModeAim;
		private wCHandle<gameweaponObject> _leftHandObject;

		[Ordinal(0)] 
		[RED("chargeModeAim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> ChargeModeAim
		{
			get
			{
				if (_chargeModeAim == null)
				{
					_chargeModeAim = (CHandle<gameweaponAnimFeature_AimPlayer>) CR2WTypeManager.Create("handle:gameweaponAnimFeature_AimPlayer", "chargeModeAim", cr2w, this);
				}
				return _chargeModeAim;
			}
			set
			{
				if (_chargeModeAim == value)
				{
					return;
				}
				_chargeModeAim = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("leftHandObject")] 
		public wCHandle<gameweaponObject> LeftHandObject
		{
			get
			{
				if (_leftHandObject == null)
				{
					_leftHandObject = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "leftHandObject", cr2w, this);
				}
				return _leftHandObject;
			}
			set
			{
				if (_leftHandObject == value)
				{
					return;
				}
				_leftHandObject = value;
				PropertySet(this);
			}
		}

		public LeftHandCyberwareChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
