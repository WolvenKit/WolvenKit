using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Text : vgBaseVectorGraphicShape
	{
		private CString _xt;

		[Ordinal(2)] 
		[RED("xt")] 
		public CString Xt
		{
			get => GetProperty(ref _xt);
			set => SetProperty(ref _xt, value);
		}
	}
}
