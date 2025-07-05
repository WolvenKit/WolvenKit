
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionMissileRainGrid_Record
	{
		[RED("missileOffsets")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector3> MissileOffsets
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}
	}
}
