
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFxCollision_Record
	{
		[RED("materials")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Materials
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
