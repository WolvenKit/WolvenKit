
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDestructionPointDamper_Record
	{
		[RED("dampValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat DampValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pointFragility")]
		[REDProperty(IsIgnored = true)]
		public CFloat PointFragility
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pointIndex")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PointIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
