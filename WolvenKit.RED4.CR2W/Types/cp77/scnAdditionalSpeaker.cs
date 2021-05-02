using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAdditionalSpeaker : CVariable
	{
		private scnActorId _actorId;
		private CEnum<scnAdditionalSpeakerType> _type;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<scnAdditionalSpeakerType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public scnAdditionalSpeaker(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
