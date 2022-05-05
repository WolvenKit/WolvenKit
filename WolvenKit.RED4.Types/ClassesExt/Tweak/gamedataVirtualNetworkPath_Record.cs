
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVirtualNetworkPath_Record
	{
		[RED("points")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector3> Points
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}
	}
}
