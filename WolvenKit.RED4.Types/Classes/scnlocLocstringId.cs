using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnlocLocstringId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}
	}
}
