using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTPPRepresentationComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("detachedObjectInfo")] 
		public CArray<gameFppRepDetachedObjectInfo> DetachedObjectInfo
		{
			get => GetPropertyValue<CArray<gameFppRepDetachedObjectInfo>>();
			set => SetPropertyValue<CArray<gameFppRepDetachedObjectInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("attachedObjectInfo")] 
		public CArray<gameTppRepAttachedObjectInfo> AttachedObjectInfo
		{
			get => GetPropertyValue<CArray<gameTppRepAttachedObjectInfo>>();
			set => SetPropertyValue<CArray<gameTppRepAttachedObjectInfo>>(value);
		}

		[Ordinal(5)] 
		[RED("affectedAppearanceSlots")] 
		public CArray<TweakDBID> AffectedAppearanceSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public gameTPPRepresentationComponent()
		{
			Name = "Component";
			DetachedObjectInfo = new();
			AttachedObjectInfo = new();
			AffectedAppearanceSlots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
