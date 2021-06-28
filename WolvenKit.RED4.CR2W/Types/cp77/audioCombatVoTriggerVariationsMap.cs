using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMap : audioAudioMetadata
	{
		private CArray<audioCombatVoTriggerVariationsMapItem> _voTriggerVariations;

		[Ordinal(1)] 
		[RED("voTriggerVariations")] 
		public CArray<audioCombatVoTriggerVariationsMapItem> VoTriggerVariations
		{
			get => GetProperty(ref _voTriggerVariations);
			set => SetProperty(ref _voTriggerVariations, value);
		}

		public audioCombatVoTriggerVariationsMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
