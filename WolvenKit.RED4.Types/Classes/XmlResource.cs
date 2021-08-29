using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class XmlResource : CResource
	{
		private CString _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CString Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
