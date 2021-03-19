using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopMaterialListDescriptor : CVariable
	{
		private CString _chunksInfo;
		private CString _chunksLODInfo;
		private CUInt32 _numLayers;
		private CBool _isForward;
		private CBool _isMultilayer;
		private CBool _isLocalInstance;
		private CBool _isTemplate;
		private CUInt32 _itemMaterialIndex;
		private CString _materialName;
		private CString _appearanceName;
		private CArray<CString> _availableMaterials;

		[Ordinal(0)] 
		[RED("chunksInfo")] 
		public CString ChunksInfo
		{
			get => GetProperty(ref _chunksInfo);
			set => SetProperty(ref _chunksInfo, value);
		}

		[Ordinal(1)] 
		[RED("chunksLODInfo")] 
		public CString ChunksLODInfo
		{
			get => GetProperty(ref _chunksLODInfo);
			set => SetProperty(ref _chunksLODInfo, value);
		}

		[Ordinal(2)] 
		[RED("numLayers")] 
		public CUInt32 NumLayers
		{
			get => GetProperty(ref _numLayers);
			set => SetProperty(ref _numLayers, value);
		}

		[Ordinal(3)] 
		[RED("isForward")] 
		public CBool IsForward
		{
			get => GetProperty(ref _isForward);
			set => SetProperty(ref _isForward, value);
		}

		[Ordinal(4)] 
		[RED("isMultilayer")] 
		public CBool IsMultilayer
		{
			get => GetProperty(ref _isMultilayer);
			set => SetProperty(ref _isMultilayer, value);
		}

		[Ordinal(5)] 
		[RED("isLocalInstance")] 
		public CBool IsLocalInstance
		{
			get => GetProperty(ref _isLocalInstance);
			set => SetProperty(ref _isLocalInstance, value);
		}

		[Ordinal(6)] 
		[RED("isTemplate")] 
		public CBool IsTemplate
		{
			get => GetProperty(ref _isTemplate);
			set => SetProperty(ref _isTemplate, value);
		}

		[Ordinal(7)] 
		[RED("itemMaterialIndex")] 
		public CUInt32 ItemMaterialIndex
		{
			get => GetProperty(ref _itemMaterialIndex);
			set => SetProperty(ref _itemMaterialIndex, value);
		}

		[Ordinal(8)] 
		[RED("materialName")] 
		public CString MaterialName
		{
			get => GetProperty(ref _materialName);
			set => SetProperty(ref _materialName, value);
		}

		[Ordinal(9)] 
		[RED("appearanceName")] 
		public CString AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(10)] 
		[RED("availableMaterials")] 
		public CArray<CString> AvailableMaterials
		{
			get => GetProperty(ref _availableMaterials);
			set => SetProperty(ref _availableMaterials, value);
		}

		public interopMaterialListDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
