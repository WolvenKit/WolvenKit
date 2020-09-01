using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayAdditiveAnimation : CVariable
	{
		[Ordinal(1)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(2)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(3)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(4)] [RED("chance")] 		public CFloat Chance { get; set;}

		[Ordinal(5)] [RED("onlyOnce")] 		public CBool OnlyOnce { get; set;}

		[Ordinal(6)] [RED("useWeightRange")] 		public CBool UseWeightRange { get; set;}

		[Ordinal(7)] [RED("weightRangeMin")] 		public CFloat WeightRangeMin { get; set;}

		[Ordinal(8)] [RED("weightRangeMax")] 		public CFloat WeightRangeMax { get; set;}

		[Ordinal(9)] [RED("useSpeedRange")] 		public CBool UseSpeedRange { get; set;}

		[Ordinal(10)] [RED("speedRangeMin")] 		public CFloat SpeedRangeMin { get; set;}

		[Ordinal(11)] [RED("speedRangeMax")] 		public CFloat SpeedRangeMax { get; set;}

		public SGameplayAdditiveAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayAdditiveAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}