using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CReflectionProbeDataResource : resStreamedResource
	{
		private DataBuffer _data;
		private rendRenderTextureResource _textureData;
		private CUInt64 _dataHash;
		private CBool _haveSkyData;
		private CArrayFixedSize<CFloat> _faceDepth;

		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("textureData")] 
		public rendRenderTextureResource TextureData
		{
			get => GetProperty(ref _textureData);
			set => SetProperty(ref _textureData, value);
		}

		[Ordinal(3)] 
		[RED("dataHash")] 
		public CUInt64 DataHash
		{
			get => GetProperty(ref _dataHash);
			set => SetProperty(ref _dataHash, value);
		}

		[Ordinal(4)] 
		[RED("haveSkyData")] 
		public CBool HaveSkyData
		{
			get => GetProperty(ref _haveSkyData);
			set => SetProperty(ref _haveSkyData, value);
		}

		[Ordinal(5)] 
		[RED("faceDepth", 6)] 
		public CArrayFixedSize<CFloat> FaceDepth
		{
			get => GetProperty(ref _faceDepth);
			set => SetProperty(ref _faceDepth, value);
		}

		public CReflectionProbeDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
