using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopTerrainEditToolInfo : RedBaseClass
	{
		private CInt32 _defaultHeightmapMode;
		private CInt32 _defaultEmptyHeightmapWidth;
		private CInt32 _defaultEmptyHeightmapHeight;
		private CFloat _defaultEmptyHeightmapMaskFalloff;
		private CFloat _defaultEmptyHeightmapMaskRoundness;
		private CUInt32 _defaultEmptyHeightmapZeroMaskMargin;
		private CString _defaultHeightmap1;
		private CString _defaultHeightmap2;
		private CString _defaultColormap1;
		private CString _defaultColormap2;
		private CArray<interopTerrainEditToolCreationSlotInfo> _creationSlots;

		[Ordinal(0)] 
		[RED("defaultHeightmapMode")] 
		public CInt32 DefaultHeightmapMode
		{
			get => GetProperty(ref _defaultHeightmapMode);
			set => SetProperty(ref _defaultHeightmapMode, value);
		}

		[Ordinal(1)] 
		[RED("defaultEmptyHeightmapWidth")] 
		public CInt32 DefaultEmptyHeightmapWidth
		{
			get => GetProperty(ref _defaultEmptyHeightmapWidth);
			set => SetProperty(ref _defaultEmptyHeightmapWidth, value);
		}

		[Ordinal(2)] 
		[RED("defaultEmptyHeightmapHeight")] 
		public CInt32 DefaultEmptyHeightmapHeight
		{
			get => GetProperty(ref _defaultEmptyHeightmapHeight);
			set => SetProperty(ref _defaultEmptyHeightmapHeight, value);
		}

		[Ordinal(3)] 
		[RED("defaultEmptyHeightmapMaskFalloff")] 
		public CFloat DefaultEmptyHeightmapMaskFalloff
		{
			get => GetProperty(ref _defaultEmptyHeightmapMaskFalloff);
			set => SetProperty(ref _defaultEmptyHeightmapMaskFalloff, value);
		}

		[Ordinal(4)] 
		[RED("defaultEmptyHeightmapMaskRoundness")] 
		public CFloat DefaultEmptyHeightmapMaskRoundness
		{
			get => GetProperty(ref _defaultEmptyHeightmapMaskRoundness);
			set => SetProperty(ref _defaultEmptyHeightmapMaskRoundness, value);
		}

		[Ordinal(5)] 
		[RED("defaultEmptyHeightmapZeroMaskMargin")] 
		public CUInt32 DefaultEmptyHeightmapZeroMaskMargin
		{
			get => GetProperty(ref _defaultEmptyHeightmapZeroMaskMargin);
			set => SetProperty(ref _defaultEmptyHeightmapZeroMaskMargin, value);
		}

		[Ordinal(6)] 
		[RED("defaultHeightmap1")] 
		public CString DefaultHeightmap1
		{
			get => GetProperty(ref _defaultHeightmap1);
			set => SetProperty(ref _defaultHeightmap1, value);
		}

		[Ordinal(7)] 
		[RED("defaultHeightmap2")] 
		public CString DefaultHeightmap2
		{
			get => GetProperty(ref _defaultHeightmap2);
			set => SetProperty(ref _defaultHeightmap2, value);
		}

		[Ordinal(8)] 
		[RED("defaultColormap1")] 
		public CString DefaultColormap1
		{
			get => GetProperty(ref _defaultColormap1);
			set => SetProperty(ref _defaultColormap1, value);
		}

		[Ordinal(9)] 
		[RED("defaultColormap2")] 
		public CString DefaultColormap2
		{
			get => GetProperty(ref _defaultColormap2);
			set => SetProperty(ref _defaultColormap2, value);
		}

		[Ordinal(10)] 
		[RED("creationSlots")] 
		public CArray<interopTerrainEditToolCreationSlotInfo> CreationSlots
		{
			get => GetProperty(ref _creationSlots);
			set => SetProperty(ref _creationSlots, value);
		}
	}
}
