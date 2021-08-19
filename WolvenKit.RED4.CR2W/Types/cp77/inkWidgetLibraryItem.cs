using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItem : CVariable
	{
		private CName _name;
		private SharedDataBuffer _package;
		private DataBuffer _packageData;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("package")] 
		public SharedDataBuffer Package
		{
			get => GetProperty(ref _package);
			set => SetProperty(ref _package, value);
		}

		[Ordinal(2)] 
		[RED("packageData")] 
		public DataBuffer PackageData
		{
			get => GetProperty(ref _packageData);
			set => SetProperty(ref _packageData, value);
		}

		public inkWidgetLibraryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
