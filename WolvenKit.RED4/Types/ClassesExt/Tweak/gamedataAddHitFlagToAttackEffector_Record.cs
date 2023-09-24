
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAddHitFlagToAttackEffector_Record
	{
		[RED("hitFlag")]
		[REDProperty(IsIgnored = true)]
		public CString HitFlag
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
