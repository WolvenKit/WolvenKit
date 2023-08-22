using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsReactionData : IScriptable
	{
		[Ordinal(0)] 
		[RED("choiceName")] 
		public CName ChoiceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("startDuration")] 
		public CFloat StartDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("endDuration")] 
		public CFloat EndDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("interactionDuration")] 
		public CFloat InteractionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("requiredEquips")] 
		public CArray<gameEquipParam> RequiredEquips
		{
			get => GetPropertyValue<CArray<gameEquipParam>>();
			set => SetPropertyValue<CArray<gameEquipParam>>(value);
		}

		[Ordinal(6)] 
		[RED("interactionPoint")] 
		public Transform InteractionPoint
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(7)] 
		[RED("useIK")] 
		public CBool UseIK
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("IKPoint")] 
		public Vector4 IKPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameinteractionsReactionData()
		{
			StartDuration = 1.000000F;
			EndDuration = 1.000000F;
			InteractionDuration = -1.000000F;
			RequiredEquips = new();
			InteractionPoint = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			IKPoint = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
