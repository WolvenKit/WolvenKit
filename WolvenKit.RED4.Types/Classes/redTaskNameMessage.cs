using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTaskNameMessage : RedBaseClass
	{
		private CUInt32 _id;
		private CString _title;
		private CName _uniqueName;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("uniqueName")] 
		public CName UniqueName
		{
			get => GetProperty(ref _uniqueName);
			set => SetProperty(ref _uniqueName, value);
		}
	}
}
