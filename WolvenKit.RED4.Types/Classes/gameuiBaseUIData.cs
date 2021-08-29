using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseUIData : RedBaseClass
	{
		private CInt64 _id;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt64 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
