using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftStatus : BaseDeviceStatus
	{
		private CName _libraryName;

		[Ordinal(26)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetProperty(ref _libraryName);
			set => SetProperty(ref _libraryName, value);
		}

		public LiftStatus(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
