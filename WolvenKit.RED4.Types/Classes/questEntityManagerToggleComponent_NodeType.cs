using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityManagerToggleComponent_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questEntityManagerToggleComponent_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questEntityManagerToggleComponent_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questEntityManagerToggleComponent_NodeTypeParams>>(value);
		}

		public questEntityManagerToggleComponent_NodeType()
		{
			Params = new() { new() };
		}
	}
}
