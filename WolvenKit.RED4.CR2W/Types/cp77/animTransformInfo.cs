using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animTransformInfo : CVariable
	{
		private CName _name;
		private CName _parentName;
		private QsTransform _referenceTransformLs;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("parentName")] 
		public CName ParentName
		{
			get => GetProperty(ref _parentName);
			set => SetProperty(ref _parentName, value);
		}

		[Ordinal(2)] 
		[RED("referenceTransformLs")] 
		public QsTransform ReferenceTransformLs
		{
			get => GetProperty(ref _referenceTransformLs);
			set => SetProperty(ref _referenceTransformLs, value);
		}

		public animTransformInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
