using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDismemberedBodyPartEvent : redEvent
	{
		private CStatic<CName> _bones;

		[Ordinal(0)] 
		[RED("bones", 32)] 
		public CStatic<CName> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}
	}
}
