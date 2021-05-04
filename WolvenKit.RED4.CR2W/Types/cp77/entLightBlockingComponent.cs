using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLightBlockingComponent : entIVisualComponent
	{
		private CFloat _radius;
		private CUInt8 _lightBlockerComponentVersion;

		[Ordinal(8)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(9)] 
		[RED("lightBlockerComponentVersion")] 
		public CUInt8 LightBlockerComponentVersion
		{
			get => GetProperty(ref _lightBlockerComponentVersion);
			set => SetProperty(ref _lightBlockerComponentVersion, value);
		}

		public entLightBlockingComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
