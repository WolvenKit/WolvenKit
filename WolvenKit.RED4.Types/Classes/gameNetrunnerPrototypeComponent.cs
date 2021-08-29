using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeComponent : entIComponent
	{
		private CArray<gameNetrunnerPrototypeStruct> _structs;

		[Ordinal(3)] 
		[RED("structs")] 
		public CArray<gameNetrunnerPrototypeStruct> Structs
		{
			get => GetProperty(ref _structs);
			set => SetProperty(ref _structs, value);
		}
	}
}
