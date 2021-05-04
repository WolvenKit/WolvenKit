using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeOptionGridButtonData : CVariable
	{
		private CName _imagePart;
		private redResourceReferenceScriptToken _atlasResource;
		private CInt32 _optionData;

		[Ordinal(0)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetProperty(ref _imagePart);
			set => SetProperty(ref _imagePart, value);
		}

		[Ordinal(1)] 
		[RED("atlasResource")] 
		public redResourceReferenceScriptToken AtlasResource
		{
			get => GetProperty(ref _atlasResource);
			set => SetProperty(ref _atlasResource, value);
		}

		[Ordinal(2)] 
		[RED("optionData")] 
		public CInt32 OptionData
		{
			get => GetProperty(ref _optionData);
			set => SetProperty(ref _optionData, value);
		}

		public gameuiPhotoModeOptionGridButtonData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
