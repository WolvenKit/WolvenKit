using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialInstance : IMaterial
	{
		private CResourceReference<IMaterial> _baseMaterial;
		private CBool _enableMask;
		private CName _audioTag;
		private CUInt8 _resourceVersion;

		[Ordinal(1)] 
		[RED("baseMaterial")] 
		public CResourceReference<IMaterial> BaseMaterial
		{
			get => GetProperty(ref _baseMaterial);
			set => SetProperty(ref _baseMaterial, value);
		}

		[Ordinal(2)] 
		[RED("enableMask")] 
		public CBool EnableMask
		{
			get => GetProperty(ref _enableMask);
			set => SetProperty(ref _enableMask, value);
		}

		[Ordinal(3)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetProperty(ref _audioTag);
			set => SetProperty(ref _audioTag, value);
		}

		[Ordinal(4)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetProperty(ref _resourceVersion);
			set => SetProperty(ref _resourceVersion, value);
		}
	}
}
