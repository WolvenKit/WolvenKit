using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopMaterialListDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chunksInfo")] 
		public CString ChunksInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("chunksLODInfo")] 
		public CString ChunksLODInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("numLayers")] 
		public CUInt32 NumLayers
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("isForward")] 
		public CBool IsForward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isMultilayer")] 
		public CBool IsMultilayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isLocalInstance")] 
		public CBool IsLocalInstance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isTemplate")] 
		public CBool IsTemplate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("itemMaterialIndex")] 
		public CUInt32 ItemMaterialIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("materialName")] 
		public CString MaterialName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("appearanceName")] 
		public CString AppearanceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("availableMaterials")] 
		public CArray<CString> AvailableMaterials
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public interopMaterialListDescriptor()
		{
			AppearanceName = "default";
			AvailableMaterials = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
