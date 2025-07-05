
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAddDevelopmentPointEffector_Record
	{
		[RED("amountOfPoints")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AmountOfPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("pointsType")]
		[REDProperty(IsIgnored = true)]
		public CString PointsType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
