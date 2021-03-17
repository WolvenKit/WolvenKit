using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TreeItem : ISerializable
	{
		private CName _className;
		private CFloat _exclusiveTimeMS;
		private CFloat _inclusiveTimeMS;
		private CArray<CHandle<animAnimProfilerData_TreeItem>> _children;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("exclusiveTimeMS")] 
		public CFloat ExclusiveTimeMS
		{
			get => GetProperty(ref _exclusiveTimeMS);
			set => SetProperty(ref _exclusiveTimeMS, value);
		}

		[Ordinal(2)] 
		[RED("inclusiveTimeMS")] 
		public CFloat InclusiveTimeMS
		{
			get => GetProperty(ref _inclusiveTimeMS);
			set => SetProperty(ref _inclusiveTimeMS, value);
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CHandle<animAnimProfilerData_TreeItem>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		public animAnimProfilerData_TreeItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
