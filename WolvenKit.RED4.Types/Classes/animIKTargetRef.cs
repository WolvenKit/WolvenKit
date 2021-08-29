using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animIKTargetRef : RedBaseClass
	{
		private CInt32 _id;
		private CName _part;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("part")] 
		public CName Part
		{
			get => GetProperty(ref _part);
			set => SetProperty(ref _part, value);
		}
	}
}
