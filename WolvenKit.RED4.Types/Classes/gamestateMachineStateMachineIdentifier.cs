using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateMachineIdentifier : RedBaseClass
	{
		private CName _definitionName;
		private CName _referenceName;

		[Ordinal(0)] 
		[RED("definitionName")] 
		public CName DefinitionName
		{
			get => GetProperty(ref _definitionName);
			set => SetProperty(ref _definitionName, value);
		}

		[Ordinal(1)] 
		[RED("referenceName")] 
		public CName ReferenceName
		{
			get => GetProperty(ref _referenceName);
			set => SetProperty(ref _referenceName, value);
		}
	}
}
