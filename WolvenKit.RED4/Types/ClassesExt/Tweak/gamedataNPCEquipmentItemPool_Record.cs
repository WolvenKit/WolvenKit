
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNPCEquipmentItemPool_Record
	{
		[RED("pool")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Pool
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
