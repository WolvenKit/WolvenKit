using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatInvalid : AIAIEvent
	{
		private wCHandle<entEntity> _owner;
		private wCHandle<entEntity> _threat;
		private CBool _isEnemy;
		private CBool _isHostile;

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
		[RED("isEnemy")] 
		public CBool IsEnemy
		{
			get => GetProperty(ref _isEnemy);
			set => SetProperty(ref _isEnemy, value);
		}

		[Ordinal(5)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetProperty(ref _isHostile);
			set => SetProperty(ref _isHostile, value);
		}

		public AIThreatInvalid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
