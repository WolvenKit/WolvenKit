using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNotPrereq : gameIPrereq
	{
		private CHandle<gameIPrereq> _negatedPrereq;

		[Ordinal(0)] 
		[RED("negatedPrereq")] 
		public CHandle<gameIPrereq> NegatedPrereq
		{
			get => GetProperty(ref _negatedPrereq);
			set => SetProperty(ref _negatedPrereq, value);
		}
	}
}
