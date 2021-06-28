using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameUILocalizationDataPackage : IScriptable
	{
		private CArray<CFloat> _floatValues;
		private CArray<CInt32> _intValues;
		private CArray<CName> _nameValues;
		private CArray<CFloat> _statValues;
		private CArray<CName> _statNames;
		private CInt32 _paramsCount;
		private CHandle<textTextParameterSet> _textParams;

		[Ordinal(0)] 
		[RED("floatValues")] 
		public CArray<CFloat> FloatValues
		{
			get => GetProperty(ref _floatValues);
			set => SetProperty(ref _floatValues, value);
		}

		[Ordinal(1)] 
		[RED("intValues")] 
		public CArray<CInt32> IntValues
		{
			get => GetProperty(ref _intValues);
			set => SetProperty(ref _intValues, value);
		}

		[Ordinal(2)] 
		[RED("nameValues")] 
		public CArray<CName> NameValues
		{
			get => GetProperty(ref _nameValues);
			set => SetProperty(ref _nameValues, value);
		}

		[Ordinal(3)] 
		[RED("statValues")] 
		public CArray<CFloat> StatValues
		{
			get => GetProperty(ref _statValues);
			set => SetProperty(ref _statValues, value);
		}

		[Ordinal(4)] 
		[RED("statNames")] 
		public CArray<CName> StatNames
		{
			get => GetProperty(ref _statNames);
			set => SetProperty(ref _statNames, value);
		}

		[Ordinal(5)] 
		[RED("paramsCount")] 
		public CInt32 ParamsCount
		{
			get => GetProperty(ref _paramsCount);
			set => SetProperty(ref _paramsCount, value);
		}

		[Ordinal(6)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetProperty(ref _textParams);
			set => SetProperty(ref _textParams, value);
		}

		public gameUILocalizationDataPackage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
