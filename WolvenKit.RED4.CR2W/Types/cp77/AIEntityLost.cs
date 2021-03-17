using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEntityLost : AIAIEvent
	{
		private wCHandle<entEntity> _spotter;
		private wCHandle<entEntity> _spotted;
		private CBool _isHostile;

		[Ordinal(2)] 
		[RED("spotter")] 
		public wCHandle<entEntity> Spotter
		{
			get => GetProperty(ref _spotter);
			set => SetProperty(ref _spotter, value);
		}

		[Ordinal(3)] 
		[RED("spotted")] 
		public wCHandle<entEntity> Spotted
		{
			get => GetProperty(ref _spotted);
			set => SetProperty(ref _spotted, value);
		}

		[Ordinal(4)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetProperty(ref _isHostile);
			set => SetProperty(ref _isHostile, value);
		}

		public AIEntityLost(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
