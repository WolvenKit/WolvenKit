using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatDefeated : AIAIEvent
	{
		private wCHandle<entEntity> _owner;
		private wCHandle<entEntity> _threat;
		private CUInt32 _id;
		private CBool _detected;

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("threat")] 
		public wCHandle<entEntity> Threat
		{
			get => GetProperty(ref _threat);
			set => SetProperty(ref _threat, value);
		}

		[Ordinal(4)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(5)] 
		[RED("detected")] 
		public CBool Detected
		{
			get => GetProperty(ref _detected);
			set => SetProperty(ref _detected, value);
		}

		public AIThreatDefeated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
