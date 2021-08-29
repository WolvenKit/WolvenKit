using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkKeyBindingEvent : redEvent
	{
		private CName _keyName;

		[Ordinal(0)] 
		[RED("keyName")] 
		public CName KeyName
		{
			get => GetProperty(ref _keyName);
			set => SetProperty(ref _keyName, value);
		}
	}
}
