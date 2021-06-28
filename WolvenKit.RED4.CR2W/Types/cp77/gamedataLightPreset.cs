using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataLightPreset : CVariable
	{
		private CName _lightSourcesName;
		private TweakDBID _preset;

		[Ordinal(0)] 
		[RED("lightSourcesName")] 
		public CName LightSourcesName
		{
			get => GetProperty(ref _lightSourcesName);
			set => SetProperty(ref _lightSourcesName, value);
		}

		[Ordinal(1)] 
		[RED("preset")] 
		public TweakDBID Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}

		public gamedataLightPreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
