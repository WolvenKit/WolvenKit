using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleVisWireMaster : gameObject
	{
		[Ordinal(35)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(36)] 
		[RED("inFocus")] 
		public CBool InFocus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("found")] 
		public CBool Found
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("lookedAt")] 
		public CBool LookedAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public sampleVisWireMaster()
		{
			DependableEntities = new();
		}
	}
}
