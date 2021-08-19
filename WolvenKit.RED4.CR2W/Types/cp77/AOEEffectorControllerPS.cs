using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEEffectorControllerPS : ActivatedDeviceControllerPS
	{
		private CArray<CName> _effectsToPlay;

		[Ordinal(108)] 
		[RED("effectsToPlay")] 
		public CArray<CName> EffectsToPlay
		{
			get => GetProperty(ref _effectsToPlay);
			set => SetProperty(ref _effectsToPlay, value);
		}

		public AOEEffectorControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
