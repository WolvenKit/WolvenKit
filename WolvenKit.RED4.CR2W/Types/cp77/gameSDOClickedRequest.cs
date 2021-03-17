using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSDOClickedRequest : gameScriptableSystemRequest
	{
		private CName _fullPath;
		private CName _key;

		[Ordinal(0)] 
		[RED("fullPath")] 
		public CName FullPath
		{
			get => GetProperty(ref _fullPath);
			set => SetProperty(ref _fullPath, value);
		}

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		public gameSDOClickedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
