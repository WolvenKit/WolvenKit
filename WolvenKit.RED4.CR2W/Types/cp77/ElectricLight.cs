using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricLight : Device
	{
		private CArray<CHandle<gameLightComponent>> _lightComponents;
		private CArray<gamedataLightPreset> _lightDefinitions;

		[Ordinal(87)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetProperty(ref _lightComponents);
			set => SetProperty(ref _lightComponents, value);
		}

		[Ordinal(88)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get => GetProperty(ref _lightDefinitions);
			set => SetProperty(ref _lightDefinitions, value);
		}

		public ElectricLight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
