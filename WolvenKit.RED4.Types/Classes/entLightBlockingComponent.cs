using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entLightBlockingComponent : entIVisualComponent
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
	}
}
