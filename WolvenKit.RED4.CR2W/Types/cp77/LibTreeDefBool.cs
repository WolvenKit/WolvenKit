using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefBool : CVariable
	{
		private CUInt16 _variableId;
		private CName _treeVariable;
		private CBool _v;

		[Ordinal(0)] 
		[RED("variableId")] 
		public CUInt16 VariableId
		{
			get => GetProperty(ref _variableId);
			set => SetProperty(ref _variableId, value);
		}

		[Ordinal(1)] 
		[RED("treeVariable")] 
		public CName TreeVariable
		{
			get => GetProperty(ref _treeVariable);
			set => SetProperty(ref _treeVariable, value);
		}

		[Ordinal(2)] 
		[RED("v")] 
		public CBool V
		{
			get => GetProperty(ref _v);
			set => SetProperty(ref _v, value);
		}

		public LibTreeDefBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
