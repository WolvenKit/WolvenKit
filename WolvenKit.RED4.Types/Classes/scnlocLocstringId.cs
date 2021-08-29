using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnlocLocstringId : RedBaseClass
	{
		private CRUID _ruid;

		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetProperty(ref _ruid);
			set => SetProperty(ref _ruid, value);
		}
	}
}
