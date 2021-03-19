using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfileData_RootItem : ISerializable
	{
		private CFloat _timeMS;
		private CArray<CHandle<animAnimProfilerData_TreeItem>> _children;

		[Ordinal(0)] 
		[RED("timeMS")] 
		public CFloat TimeMS
		{
			get => GetProperty(ref _timeMS);
			set => SetProperty(ref _timeMS, value);
		}

		[Ordinal(1)] 
		[RED("children")] 
		public CArray<CHandle<animAnimProfilerData_TreeItem>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		public animAnimProfileData_RootItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
