using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayAdditiveAnimation : CVariable
	{
		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("delay")] 		public CFloat Delay { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("chance")] 		public CFloat Chance { get; set;}

		[RED("onlyOnce")] 		public CBool OnlyOnce { get; set;}

		[RED("useWeightRange")] 		public CBool UseWeightRange { get; set;}

		[RED("weightRangeMin")] 		public CFloat WeightRangeMin { get; set;}

		[RED("weightRangeMax")] 		public CFloat WeightRangeMax { get; set;}

		[RED("useSpeedRange")] 		public CBool UseSpeedRange { get; set;}

		[RED("speedRangeMin")] 		public CFloat SpeedRangeMin { get; set;}

		[RED("speedRangeMax")] 		public CFloat SpeedRangeMax { get; set;}

		public SGameplayAdditiveAnimation(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SGameplayAdditiveAnimation(cr2w);

	}
}