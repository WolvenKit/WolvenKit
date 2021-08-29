using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animTransformInfo : RedBaseClass
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
	}
}
