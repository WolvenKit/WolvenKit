using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class AbsolutePathSerializable : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Path")] 
		public CString Path
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
