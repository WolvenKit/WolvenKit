using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqsResource : CResource
	{
		private CArray<gamePrereqDefinition> _prereqs;

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<gamePrereqDefinition> Prereqs
		{
			get => GetProperty(ref _prereqs);
			set => SetProperty(ref _prereqs, value);
		}
	}
}
