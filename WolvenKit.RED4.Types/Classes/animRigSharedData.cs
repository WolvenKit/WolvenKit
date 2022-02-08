using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRigSharedData : CResource
	{
		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get => GetPropertyValue<CArray<animRigPart>>();
			set => SetPropertyValue<CArray<animRigPart>>(value);
		}

		[Ordinal(2)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get => GetPropertyValue<CArray<CHandle<animIRigIkSetup>>>();
			set => SetPropertyValue<CArray<CHandle<animIRigIkSetup>>>(value);
		}

		public animRigSharedData()
		{
			Parts = new();
			IkSetups = new();
		}
	}
}
