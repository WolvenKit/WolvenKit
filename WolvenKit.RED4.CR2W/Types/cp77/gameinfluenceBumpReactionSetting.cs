using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpReactionSetting : ISerializable
	{
		private CEnum<gameinteractionsBumpIntensity> _reaction;
		private CFloat _maxVelocity;

		[Ordinal(0)] 
		[RED("reaction")] 
		public CEnum<gameinteractionsBumpIntensity> Reaction
		{
			get => GetProperty(ref _reaction);
			set => SetProperty(ref _reaction, value);
		}

		[Ordinal(1)] 
		[RED("maxVelocity")] 
		public CFloat MaxVelocity
		{
			get => GetProperty(ref _maxVelocity);
			set => SetProperty(ref _maxVelocity, value);
		}

		public gameinfluenceBumpReactionSetting(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
