using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSOwnerData : RedBaseClass
	{
		private gamePersistentID _id;
		private CName _className;

		[Ordinal(0)] 
		[RED("id")] 
		public gamePersistentID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}
	}
}
