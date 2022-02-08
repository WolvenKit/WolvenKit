using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNotPrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("negatedPrereq")] 
		public CHandle<gameIPrereq> NegatedPrereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}
	}
}
