using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyLightPresetEffector : gameEffector
	{
		private wCHandle<gamedataLightPreset_Record> _lightPreset;

		[Ordinal(0)] 
		[RED("lightPreset")] 
		public wCHandle<gamedataLightPreset_Record> LightPreset
		{
			get => GetProperty(ref _lightPreset);
			set => SetProperty(ref _lightPreset, value);
		}

		public ApplyLightPresetEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
