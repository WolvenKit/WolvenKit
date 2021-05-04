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
			get => GetProperty(ref _chargeModeAim);
			set => SetProperty(ref _chargeModeAim, value);
		}

		[Ordinal(1)] 
		[RED("leftHandObject")] 
		public wCHandle<gameweaponObject> LeftHandObject
		{
			get => GetProperty(ref _leftHandObject);
			set => SetProperty(ref _leftHandObject, value);
		}

		public LeftHandCyberwareChargeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
