using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGlobalTierSaveData : RedBaseClass
	{
		private CEnum<gameGlobalTierSubtype> _subtype;
		private CHandle<gameSceneTierData> _data;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CEnum<gameGlobalTierSubtype> Subtype
		{
			get => GetProperty(ref _subtype);
			set => SetProperty(ref _subtype, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameSceneTierData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
