using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class aiscriptSharedVarName : CVariable
	{
		private LibTreeSharedVarReferenceName _varName;

		[Ordinal(0)] 
		[RED("varName")] 
		public LibTreeSharedVarReferenceName VarName
		{
			get => GetProperty(ref _varName);
			set => SetProperty(ref _varName, value);
		}

		public aiscriptSharedVarName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
