using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnlocLangId : RedBaseClass
	{
		private CUInt8 _langId;

		[Ordinal(0)] 
		[RED("langId")] 
		public CUInt8 LangId
		{
			get => GetProperty(ref _langId);
			set => SetProperty(ref _langId, value);
		}
	}
}
