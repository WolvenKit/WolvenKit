
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRowTraps_Record
	{
		[RED("traps")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Traps
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
	}
}
