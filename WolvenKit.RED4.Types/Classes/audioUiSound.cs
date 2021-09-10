using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiSound : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CName> Events
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioUiSound()
		{
			Events = new();
		}
	}
}
