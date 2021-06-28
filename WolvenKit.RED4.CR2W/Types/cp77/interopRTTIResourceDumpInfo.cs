using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopRTTIResourceDumpInfo : CVariable
	{
		private CString _extension;
		private CString _deprecatedExtension;
		private CString _friendlyDescription;

		[Ordinal(0)] 
		[RED("extension")] 
		public CString Extension
		{
			get => GetProperty(ref _extension);
			set => SetProperty(ref _extension, value);
		}

		[Ordinal(1)] 
		[RED("deprecatedExtension")] 
		public CString DeprecatedExtension
		{
			get => GetProperty(ref _deprecatedExtension);
			set => SetProperty(ref _deprecatedExtension, value);
		}

		[Ordinal(2)] 
		[RED("friendlyDescription")] 
		public CString FriendlyDescription
		{
			get => GetProperty(ref _friendlyDescription);
			set => SetProperty(ref _friendlyDescription, value);
		}

		public interopRTTIResourceDumpInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
