using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePuppetPS : gameObjectPS
	{
		[Ordinal(0)] 
		[RED("gender")] 
		public CName Gender
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hasAlternativeName")] 
		public CBool HasAlternativeName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isCrouch")] 
		public CBool IsCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("allowVehicleCollisionRagdoll")] 
		public CBool AllowVehicleCollisionRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamePuppetPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
