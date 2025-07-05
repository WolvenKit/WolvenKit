
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIAmmoCountCond_Record
	{
		[RED("max")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Max
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("min")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Min
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("percentage")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Percentage
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("weaponSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WeaponSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
