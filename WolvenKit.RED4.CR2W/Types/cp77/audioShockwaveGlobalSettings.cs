using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveGlobalSettings : audioAudioMetadata
	{
		private CFloat _explosionPropagationSpeed;
		private CFloat _thumpPropagationSpeed;
		private CFloat _electroshockPropagationSpeed;
		private CFloat _revealPropagationSpeed;

		[Ordinal(1)] 
		[RED("explosionPropagationSpeed")] 
		public CFloat ExplosionPropagationSpeed
		{
			get => GetProperty(ref _explosionPropagationSpeed);
			set => SetProperty(ref _explosionPropagationSpeed, value);
		}

		[Ordinal(2)] 
		[RED("thumpPropagationSpeed")] 
		public CFloat ThumpPropagationSpeed
		{
			get => GetProperty(ref _thumpPropagationSpeed);
			set => SetProperty(ref _thumpPropagationSpeed, value);
		}

		[Ordinal(3)] 
		[RED("electroshockPropagationSpeed")] 
		public CFloat ElectroshockPropagationSpeed
		{
			get => GetProperty(ref _electroshockPropagationSpeed);
			set => SetProperty(ref _electroshockPropagationSpeed, value);
		}

		[Ordinal(4)] 
		[RED("revealPropagationSpeed")] 
		public CFloat RevealPropagationSpeed
		{
			get => GetProperty(ref _revealPropagationSpeed);
			set => SetProperty(ref _revealPropagationSpeed, value);
		}

		public audioShockwaveGlobalSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
