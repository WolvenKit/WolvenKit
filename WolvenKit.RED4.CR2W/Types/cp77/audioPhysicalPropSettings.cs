using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalPropSettings : audioAudioMetadata
	{
		private CName _shockwaveSound;
		private CName _damagedSound;
		private CName _destroyedSound;
		private CArray<CName> _materialOverrides;

		[Ordinal(1)] 
		[RED("shockwaveSound")] 
		public CName ShockwaveSound
		{
			get => GetProperty(ref _shockwaveSound);
			set => SetProperty(ref _shockwaveSound, value);
		}

		[Ordinal(2)] 
		[RED("damagedSound")] 
		public CName DamagedSound
		{
			get => GetProperty(ref _damagedSound);
			set => SetProperty(ref _damagedSound, value);
		}

		[Ordinal(3)] 
		[RED("destroyedSound")] 
		public CName DestroyedSound
		{
			get => GetProperty(ref _destroyedSound);
			set => SetProperty(ref _destroyedSound, value);
		}

		[Ordinal(4)] 
		[RED("materialOverrides")] 
		public CArray<CName> MaterialOverrides
		{
			get => GetProperty(ref _materialOverrides);
			set => SetProperty(ref _materialOverrides, value);
		}

		public audioPhysicalPropSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
