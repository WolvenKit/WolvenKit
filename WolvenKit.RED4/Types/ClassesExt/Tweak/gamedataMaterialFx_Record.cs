
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMaterialFx_Record
	{
		[RED("impact_decal")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_decal
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_dismemberment_piercing")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_dismemberment_piercing
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_main_effect")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_main_effect
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_pierce_decal")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_pierce_decal
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_pierce_effect")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_pierce_effect
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_pierce_splatter_far")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_pierce_splatter_far
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_pierce_splatter_near")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_pierce_splatter_near
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_reflected_effect")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_reflected_effect
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("impact_underwater_effect")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> Impact_underwater_effect
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("pierce_enter")]
		[REDProperty(IsIgnored = true)]
		public CBool Pierce_enter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("pierce_exit")]
		[REDProperty(IsIgnored = true)]
		public CBool Pierce_exit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("pierce_far_distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Pierce_far_distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pierce_near_distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Pierce_near_distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("reflected_angle_max")]
		[REDProperty(IsIgnored = true)]
		public CFloat Reflected_angle_max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
