using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animTEMP_IKTargetsControllerBodyType : RedBaseClass
	{
		private CName _genderTag;
		private CName _bodyTypeTag;
		private CArray<animIKChainSettings> _ikChainSettings;

		[Ordinal(0)] 
		[RED("genderTag")] 
		public CName GenderTag
		{
			get => GetProperty(ref _genderTag);
			set => SetProperty(ref _genderTag, value);
		}

		[Ordinal(1)] 
		[RED("bodyTypeTag")] 
		public CName BodyTypeTag
		{
			get => GetProperty(ref _bodyTypeTag);
			set => SetProperty(ref _bodyTypeTag, value);
		}

		[Ordinal(2)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get => GetProperty(ref _ikChainSettings);
			set => SetProperty(ref _ikChainSettings, value);
		}
	}
}
