using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnReferencePointId : RedBaseClass
	{
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public scnReferencePointId()
		{
			_id = 4294967295;
		}
	}
}
