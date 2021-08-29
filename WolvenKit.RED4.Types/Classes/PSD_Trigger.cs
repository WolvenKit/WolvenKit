using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSD_Trigger : gameObject
	{
		private NodeRef _ref;
		private CName _className;

		[Ordinal(40)] 
		[RED("ref")] 
		public NodeRef Ref
		{
			get => GetProperty(ref _ref);
			set => SetProperty(ref _ref, value);
		}

		[Ordinal(41)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}
	}
}
