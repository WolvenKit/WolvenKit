using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWaterPatchNodeType : RedBaseClass
	{
		private CName _typeName;

		[Ordinal(0)] 
		[RED("typeName")] 
		public CName TypeName
		{
			get => GetProperty(ref _typeName);
			set => SetProperty(ref _typeName, value);
		}
	}
}
