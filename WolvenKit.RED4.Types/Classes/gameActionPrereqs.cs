using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionPrereqs : RedBaseClass
	{
		private CName _actionName;
		private CArray<CHandle<gameIPrereq>> _prereqs;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<CHandle<gameIPrereq>> Prereqs
		{
			get => GetProperty(ref _prereqs);
			set => SetProperty(ref _prereqs, value);
		}
	}
}
