using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BeingTargetByLaserSightUpdateEvent : redEvent
	{
		private wCHandle<gameweaponObject> _weapon;
		private CEnum<LaserTargettingState> _state;

		[Ordinal(0)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<LaserTargettingState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public BeingTargetByLaserSightUpdateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
