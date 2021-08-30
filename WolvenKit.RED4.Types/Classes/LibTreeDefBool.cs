using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefBool : RedBaseClass
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

		public LibTreeDefBool()
		{
			_variableId = 65535;
		}
	}
}
