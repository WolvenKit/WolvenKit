using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCookedDeviceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parents")] 
		public CArray<CUInt64> Parents
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(2)] 
		[RED("children")] 
		public CArray<CUInt64> Children
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(3)] 
		[RED("nodePosition")] 
		public Vector3 NodePosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameCookedDeviceData()
		{
			Parents = new();
			Children = new();
			NodePosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
