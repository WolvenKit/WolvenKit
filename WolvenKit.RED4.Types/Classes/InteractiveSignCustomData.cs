using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveSignCustomData : WidgetCustomData
	{
		private CString _messege;
		private CEnum<SignShape> _signShape;

		[Ordinal(0)] 
		[RED("messege")] 
		public CString Messege
		{
			get => GetProperty(ref _messege);
			set => SetProperty(ref _messege, value);
		}

		[Ordinal(1)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get => GetProperty(ref _signShape);
			set => SetProperty(ref _signShape, value);
		}
	}
}
