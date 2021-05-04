using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponFireModeSounds : CVariable
	{
		private CName _burst;
		private CName _charge;
		private CName _fullAuto;
		private CName _semiAuto;
		private CName _windup;

		[Ordinal(0)] 
		[RED("burst")] 
		public CName Burst
		{
			get => GetProperty(ref _burst);
			set => SetProperty(ref _burst, value);
		}

		[Ordinal(1)] 
		[RED("charge")] 
		public CName Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(2)] 
		[RED("fullAuto")] 
		public CName FullAuto
		{
			get => GetProperty(ref _fullAuto);
			set => SetProperty(ref _fullAuto, value);
		}

		[Ordinal(3)] 
		[RED("semiAuto")] 
		public CName SemiAuto
		{
			get => GetProperty(ref _semiAuto);
			set => SetProperty(ref _semiAuto, value);
		}

		[Ordinal(4)] 
		[RED("windup")] 
		public CName Windup
		{
			get => GetProperty(ref _windup);
			set => SetProperty(ref _windup, value);
		}

		public audioWeaponFireModeSounds(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
