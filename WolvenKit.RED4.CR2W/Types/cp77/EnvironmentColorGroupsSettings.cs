using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnvironmentColorGroupsSettings : IAreaSettings
	{
		private curveData<HDRColor> _skyTint;
		private CArrayFixedSize<curveData<HDRColor>> _colorGroup;

		[Ordinal(2)] 
		[RED("skyTint")] 
		public curveData<HDRColor> SkyTint
		{
			get => GetProperty(ref _skyTint);
			set => SetProperty(ref _skyTint, value);
		}

		[Ordinal(3)] 
		[RED("colorGroup", 16)] 
		public CArrayFixedSize<curveData<HDRColor>> ColorGroup
		{
			get => GetProperty(ref _colorGroup);
			set => SetProperty(ref _colorGroup, value);
		}

		public EnvironmentColorGroupsSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
