using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGameScreenshotInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CString Path
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("creationDate")] 
		public CUInt64 CreationDate
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("aspectRatioType")] 
		public CUInt32 AspectRatioType
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("pathHash")] 
		public CUInt32 PathHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("screenshotIndex")] 
		public CInt32 ScreenshotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("canBeDeleted")] 
		public CBool CanBeDeleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkGameScreenshotInfo()
		{
			CanBeDeleted = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
