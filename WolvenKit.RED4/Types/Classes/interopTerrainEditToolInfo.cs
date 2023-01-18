using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTerrainEditToolInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("defaultHeightmapMode")] 
		public CInt32 DefaultHeightmapMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("defaultEmptyHeightmapWidth")] 
		public CInt32 DefaultEmptyHeightmapWidth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("defaultEmptyHeightmapHeight")] 
		public CInt32 DefaultEmptyHeightmapHeight
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("defaultEmptyHeightmapMaskFalloff")] 
		public CFloat DefaultEmptyHeightmapMaskFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("defaultEmptyHeightmapMaskRoundness")] 
		public CFloat DefaultEmptyHeightmapMaskRoundness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("defaultEmptyHeightmapZeroMaskMargin")] 
		public CUInt32 DefaultEmptyHeightmapZeroMaskMargin
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("defaultHeightmap1")] 
		public CString DefaultHeightmap1
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("defaultHeightmap2")] 
		public CString DefaultHeightmap2
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("defaultColormap1")] 
		public CString DefaultColormap1
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("defaultColormap2")] 
		public CString DefaultColormap2
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("creationSlots")] 
		public CArray<interopTerrainEditToolCreationSlotInfo> CreationSlots
		{
			get => GetPropertyValue<CArray<interopTerrainEditToolCreationSlotInfo>>();
			set => SetPropertyValue<CArray<interopTerrainEditToolCreationSlotInfo>>(value);
		}

		public interopTerrainEditToolInfo()
		{
			CreationSlots = new() { new() { Scale = new() { X = 1.000000F, Y = 1.000000F }, HeightMappingMax = 100.000000F }, new() { Scale = new() { X = 1.000000F, Y = 1.000000F }, HeightMappingMax = 100.000000F }, new() { Scale = new() { X = 1.000000F, Y = 1.000000F }, HeightMappingMax = 100.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
