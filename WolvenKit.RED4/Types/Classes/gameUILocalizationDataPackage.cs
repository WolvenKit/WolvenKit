using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameUILocalizationDataPackage : IScriptable
	{
		[Ordinal(0)] 
		[RED("floatValues")] 
		public CArray<CFloat> FloatValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("intValues")] 
		public CArray<CInt32> IntValues
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("nameValues")] 
		public CArray<CName> NameValues
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("statValues")] 
		public CArray<CFloat> StatValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("statNames")] 
		public CArray<CName> StatNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("paramsCount")] 
		public CInt32 ParamsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(7)] 
		[RED("notReplacedWorkaroundEnabled")] 
		public CBool NotReplacedWorkaroundEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameUILocalizationDataPackage()
		{
			FloatValues = new();
			IntValues = new();
			NameValues = new();
			StatValues = new();
			StatNames = new();
			ParamsCount = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
