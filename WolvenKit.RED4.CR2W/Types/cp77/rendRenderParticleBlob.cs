using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlob : IRenderResourceBlob
	{
		private rendRenderParticleBlobHeader _header;
		private rendRenderParticleUpdaterData _updaterData;
		private rendEmitterSimulationShaders _gpuSimShaders;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderParticleBlobHeader Header
		{
			get
			{
				if (_header == null)
				{
					_header = (rendRenderParticleBlobHeader) CR2WTypeManager.Create("rendRenderParticleBlobHeader", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("updaterData")] 
		public rendRenderParticleUpdaterData UpdaterData
		{
			get
			{
				if (_updaterData == null)
				{
					_updaterData = (rendRenderParticleUpdaterData) CR2WTypeManager.Create("rendRenderParticleUpdaterData", "updaterData", cr2w, this);
				}
				return _updaterData;
			}
			set
			{
				if (_updaterData == value)
				{
					return;
				}
				_updaterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gpuSimShaders")] 
		public rendEmitterSimulationShaders GpuSimShaders
		{
			get
			{
				if (_gpuSimShaders == null)
				{
					_gpuSimShaders = (rendEmitterSimulationShaders) CR2WTypeManager.Create("rendEmitterSimulationShaders", "gpuSimShaders", cr2w, this);
				}
				return _gpuSimShaders;
			}
			set
			{
				if (_gpuSimShaders == value)
				{
					return;
				}
				_gpuSimShaders = value;
				PropertySet(this);
			}
		}

		public rendRenderParticleBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
