using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponMalfunctionHudEffector : gameEffector
	{
		private wCHandle<gameIBlackboard> _bb;

		[Ordinal(0)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		public WeaponMalfunctionHudEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
