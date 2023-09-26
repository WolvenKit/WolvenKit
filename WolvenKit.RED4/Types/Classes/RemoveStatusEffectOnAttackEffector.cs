using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveStatusEffectOnAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("effectTypes")] 
		public CArray<CString> EffectTypes
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(1)] 
		[RED("effectString")] 
		public CArray<CString> EffectString
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(2)] 
		[RED("effectTags")] 
		public CArray<CName> EffectTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public RemoveStatusEffectOnAttackEffector()
		{
			EffectTypes = new();
			EffectString = new();
			EffectTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
