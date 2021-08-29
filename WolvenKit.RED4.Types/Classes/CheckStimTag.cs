using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckStimTag : AIbehaviorconditionScript
	{
		private CArray<CName> _stimTagToCompare;

		[Ordinal(0)] 
		[RED("stimTagToCompare")] 
		public CArray<CName> StimTagToCompare
		{
			get => GetProperty(ref _stimTagToCompare);
			set => SetProperty(ref _stimTagToCompare, value);
		}
	}
}
