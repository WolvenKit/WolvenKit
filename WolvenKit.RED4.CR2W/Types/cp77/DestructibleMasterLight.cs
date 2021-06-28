using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructibleMasterLight : DestructibleMasterDevice
	{
		private CArray<CHandle<gameLightComponent>> _lightComponents;
		private CArray<gamedataLightPreset> _lightDefinitions;

		[Ordinal(96)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get => GetProperty(ref _lightComponents);
			set => SetProperty(ref _lightComponents, value);
		}

		[Ordinal(97)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get => GetProperty(ref _lightDefinitions);
			set => SetProperty(ref _lightDefinitions, value);
		}

		public DestructibleMasterLight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
