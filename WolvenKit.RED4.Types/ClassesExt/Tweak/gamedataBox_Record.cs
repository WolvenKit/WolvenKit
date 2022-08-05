
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBox_Record
	{
		[RED("max")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Max
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("min")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Min
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
