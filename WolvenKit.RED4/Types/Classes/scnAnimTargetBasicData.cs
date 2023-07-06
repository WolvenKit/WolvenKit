using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAnimTargetBasicData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(1)] 
		[RED("isStart")] 
		public CBool IsStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("targetPerformerId")] 
		public scnPerformerId TargetPerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(3)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("targetOffsetEntitySpace")] 
		public Vector4 TargetOffsetEntitySpace
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("staticTarget")] 
		public Vector4 StaticTarget
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("targetActorId")] 
		public scnActorId TargetActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(7)] 
		[RED("targetPropId")] 
		public scnPropId TargetPropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		[Ordinal(8)] 
		[RED("targetType")] 
		public CEnum<scnLookAtTargetType> TargetType
		{
			get => GetPropertyValue<CEnum<scnLookAtTargetType>>();
			set => SetPropertyValue<CEnum<scnLookAtTargetType>>(value);
		}

		public scnAnimTargetBasicData()
		{
			PerformerId = new scnPerformerId { Id = 4294967040 };
			IsStart = true;
			TargetPerformerId = new scnPerformerId { Id = 4294967040 };
			TargetSlot = "pla_default_tgt";
			TargetOffsetEntitySpace = new Vector4();
			StaticTarget = new Vector4 { W = 1.000000F };
			TargetActorId = new scnActorId { Id = uint.MaxValue };
			TargetPropId = new scnPropId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
