using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DangleExternalInput : animAnimFeature
	{
		private Vector4 _fictitiousAccelerationWs;

		[Ordinal(0)] 
		[RED("fictitiousAccelerationWs")] 
		public Vector4 FictitiousAccelerationWs
		{
			get => GetProperty(ref _fictitiousAccelerationWs);
			set => SetProperty(ref _fictitiousAccelerationWs, value);
		}

		public animAnimFeature_DangleExternalInput(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
