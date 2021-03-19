using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlobHeader : CVariable
	{
		private CUInt32 _version;
		private rendRenderParticleBlobEmitterInfo _emitterInfo;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("emitterInfo")] 
		public rendRenderParticleBlobEmitterInfo EmitterInfo
		{
			get => GetProperty(ref _emitterInfo);
			set => SetProperty(ref _emitterInfo, value);
		}

		public rendRenderParticleBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
