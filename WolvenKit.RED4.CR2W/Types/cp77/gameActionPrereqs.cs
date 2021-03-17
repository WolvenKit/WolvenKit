using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionPrereqs : CVariable
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

		public gameActionPrereqs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
