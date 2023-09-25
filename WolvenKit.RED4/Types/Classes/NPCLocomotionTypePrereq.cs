using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCLocomotionTypePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("locomotionMode")] 
		public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode
		{
			get => GetPropertyValue<CArray<CEnum<gamedataLocomotionMode>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataLocomotionMode>>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCLocomotionTypePrereq()
		{
			LocomotionMode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
