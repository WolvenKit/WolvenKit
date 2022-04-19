using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questOpenPhotoMode_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("factName")] 
		public CString FactName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("forceFppMode")] 
		public CBool ForceFppMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("alwaysAllowTPP")] 
		public CBool AlwaysAllowTPP
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("lockExitUntilScreenshot")] 
		public CBool LockExitUntilScreenshot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questOpenPhotoMode_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
