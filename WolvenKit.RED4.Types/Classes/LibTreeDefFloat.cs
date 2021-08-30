using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefFloat : RedBaseClass
	{
		private CUInt16 _variableId;
		private CName _treeVariable;
		private CFloat _v;

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
		public CFloat V
		{
			get => GetProperty(ref _v);
			set => SetProperty(ref _v, value);
		}

		public LibTreeDefFloat()
		{
			_variableId = 65535;
		}
	}
}
