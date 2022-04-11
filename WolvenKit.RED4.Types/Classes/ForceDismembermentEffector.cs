using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceDismembermentEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get => GetPropertyValue<CEnum<gameDismBodyPart>>();
			set => SetPropertyValue<CEnum<gameDismBodyPart>>(value);
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CEnum<gameDismWoundType> WoundType
		{
			get => GetPropertyValue<CEnum<gameDismWoundType>>();
			set => SetPropertyValue<CEnum<gameDismWoundType>>(value);
		}

		[Ordinal(2)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("skipDeathAnim")] 
		public CBool SkipDeathAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("shouldKillNPC")] 
		public CBool ShouldKillNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("dismembermentChance")] 
		public CFloat DismembermentChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataForceDismembermentEffector_Record> EffectorRecord
		{
			get => GetPropertyValue<CHandle<gamedataForceDismembermentEffector_Record>>();
			set => SetPropertyValue<CHandle<gamedataForceDismembermentEffector_Record>>(value);
		}

		public ForceDismembermentEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
