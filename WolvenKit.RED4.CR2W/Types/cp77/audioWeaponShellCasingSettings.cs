using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponShellCasingSettings : audioAudioMetadata
	{
		private CEnum<audioWeaponShellCasingMode> _mode;
		private CEnum<audioWeaponShellCasingDirection> _direction;
		private CName _firstCollisionEventName;
		private CName _secondCollisionEventName;
		private CFloat _initialDelay;

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<audioWeaponShellCasingMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<audioWeaponShellCasingDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(3)] 
		[RED("firstCollisionEventName")] 
		public CName FirstCollisionEventName
		{
			get => GetProperty(ref _firstCollisionEventName);
			set => SetProperty(ref _firstCollisionEventName, value);
		}

		[Ordinal(4)] 
		[RED("secondCollisionEventName")] 
		public CName SecondCollisionEventName
		{
			get => GetProperty(ref _secondCollisionEventName);
			set => SetProperty(ref _secondCollisionEventName, value);
		}

		[Ordinal(5)] 
		[RED("initialDelay")] 
		public CFloat InitialDelay
		{
			get => GetProperty(ref _initialDelay);
			set => SetProperty(ref _initialDelay, value);
		}

		public audioWeaponShellCasingSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
