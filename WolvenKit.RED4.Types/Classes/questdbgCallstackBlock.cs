using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questdbgCallstackBlock : RedBaseClass
	{
		private CUInt64 _id;
		private CUInt64 _parentId;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("parentId")] 
		public CUInt64 ParentId
		{
			get => GetProperty(ref _parentId);
			set => SetProperty(ref _parentId, value);
		}
	}
}
