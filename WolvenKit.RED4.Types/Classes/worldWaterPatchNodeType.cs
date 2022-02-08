using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWaterPatchNodeType : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("typeName")] 
		public CName TypeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldWaterPatchNodeType()
		{
			TypeName = "Grid_100x100";
		}
	}
}
