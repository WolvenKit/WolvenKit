using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentDebrisResourceItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(1)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		public entdismembermentDebrisResourceItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
