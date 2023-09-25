using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayContextData : IScriptable
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(2)] 
		[RED("displayComparison")] 
		public CBool DisplayComparison
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public ItemDisplayContextData()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
