using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlindingLight : BasicDistractionDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CBool _highLightActive;

		[Ordinal(102)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(103)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetProperty(ref _highLightActive);
			set => SetProperty(ref _highLightActive, value);
		}

		public BlindingLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
