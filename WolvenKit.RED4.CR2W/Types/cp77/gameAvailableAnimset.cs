using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAvailableAnimset : CVariable
	{
		private CUInt64 _hash;
		private CString _resourcePath;

		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(1)] 
		[RED("resourcePath")] 
		public CString ResourcePath
		{
			get => GetProperty(ref _resourcePath);
			set => SetProperty(ref _resourcePath, value);
		}

		public gameAvailableAnimset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
