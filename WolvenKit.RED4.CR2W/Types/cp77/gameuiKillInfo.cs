using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiKillInfo : CVariable
	{
		private wCHandle<gameObject> _killerEntity;
		private wCHandle<gameObject> _victimEntity;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("killerEntity")] 
		public wCHandle<gameObject> KillerEntity
		{
			get => GetProperty(ref _killerEntity);
			set => SetProperty(ref _killerEntity, value);
		}

		[Ordinal(1)] 
		[RED("victimEntity")] 
		public wCHandle<gameObject> VictimEntity
		{
			get => GetProperty(ref _victimEntity);
			set => SetProperty(ref _victimEntity, value);
		}

		[Ordinal(2)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetProperty(ref _killType);
			set => SetProperty(ref _killType, value);
		}

		public gameuiKillInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
