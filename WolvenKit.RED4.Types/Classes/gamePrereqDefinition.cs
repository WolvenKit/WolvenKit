using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqDefinition : RedBaseClass
	{
		private CName _prereqName;
		private CHandle<gameIPrereq> _prereq;

		[Ordinal(0)] 
		[RED("prereqName")] 
		public CName PrereqName
		{
			get => GetProperty(ref _prereqName);
			set => SetProperty(ref _prereqName, value);
		}

		[Ordinal(1)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetProperty(ref _prereq);
			set => SetProperty(ref _prereq, value);
		}
	}
}
