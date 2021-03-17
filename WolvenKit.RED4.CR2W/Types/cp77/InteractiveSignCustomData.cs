using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignCustomData : WidgetCustomData
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

		public InteractiveSignCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
