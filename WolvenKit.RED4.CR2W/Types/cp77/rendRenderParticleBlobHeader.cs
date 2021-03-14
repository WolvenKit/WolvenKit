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
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emitterInfo")] 
		public rendRenderParticleBlobEmitterInfo EmitterInfo
		{
			get
			{
				if (_emitterInfo == null)
				{
					_emitterInfo = (rendRenderParticleBlobEmitterInfo) CR2WTypeManager.Create("rendRenderParticleBlobEmitterInfo", "emitterInfo", cr2w, this);
				}
				return _emitterInfo;
			}
			set
			{
				if (_emitterInfo == value)
				{
					return;
				}
				_emitterInfo = value;
				PropertySet(this);
			}
		}

		public rendRenderParticleBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
