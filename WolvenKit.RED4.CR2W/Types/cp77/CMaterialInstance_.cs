using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialInstance_ : IMaterial
	{
		private rRef<IMaterial> _baseMaterial;
		private CBool _enableMask;
		private CName _audioTag;
		private CUInt8 _resourceVersion;

		[Ordinal(1)] 
		[RED("baseMaterial")] 
		public rRef<IMaterial> BaseMaterial
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

		public CMaterialInstance_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
