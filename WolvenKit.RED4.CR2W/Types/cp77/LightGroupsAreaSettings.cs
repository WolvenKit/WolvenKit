using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightGroupsAreaSettings : IAreaSettings
	{
		private CArrayFixedSize<curveData<CFloat>> _groupFade;

		[Ordinal(2)] 
		[RED("groupFade", 8)] 
		public CArrayFixedSize<curveData<CFloat>> GroupFade
		{
			get => GetProperty(ref _groupFade);
			set => SetProperty(ref _groupFade, value);
		}

		public LightGroupsAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
