using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineIdentifier : CVariable
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

		public gamestateMachineStateMachineIdentifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
