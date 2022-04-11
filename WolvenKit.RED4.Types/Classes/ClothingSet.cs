using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClothingSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("setID")] 
		public CInt32 SetID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("clothingList")] 
		public CArray<SSlotVisualInfo> ClothingList
		{
			get => GetPropertyValue<CArray<SSlotVisualInfo>>();
			set => SetPropertyValue<CArray<SSlotVisualInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("headHidden")] 
		public CBool HeadHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("faceHidden")] 
		public CBool FaceHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ClothingSet()
		{
			SetID = -1;
			ClothingList = new();
		}
	}
}
