using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLoopedSoundEmitterMetadata : audioEmitterMetadata
	{
		private CName _loopSound;

		[Ordinal(1)] 
		[RED("loopSound")] 
		public CName LoopSound
		{
			get => GetProperty(ref _loopSound);
			set => SetProperty(ref _loopSound, value);
		}

		public audioLoopedSoundEmitterMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
