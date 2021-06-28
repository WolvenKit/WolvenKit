using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqDefinition : CVariable
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

		public gamePrereqDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
