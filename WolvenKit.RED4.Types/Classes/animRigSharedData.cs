using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRigSharedData : CResource
	{
		private CArray<animRigPart> _parts;
		private CArray<CHandle<animIRigIkSetup>> _ikSetups;

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}

		[Ordinal(2)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get => GetProperty(ref _ikSetups);
			set => SetProperty(ref _ikSetups, value);
		}
	}
}
