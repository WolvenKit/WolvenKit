using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnSquadmateDied : redEvent
	{
		private CName _squad;
		private wCHandle<entEntity> _squadmate;
		private wCHandle<entEntity> _killer;

		[Ordinal(0)] 
		[RED("squad")] 
		public CName Squad
		{
			get => GetProperty(ref _squad);
			set => SetProperty(ref _squad, value);
		}

		[Ordinal(1)] 
		[RED("squadmate")] 
		public wCHandle<entEntity> Squadmate
		{
			get => GetProperty(ref _squadmate);
			set => SetProperty(ref _squadmate, value);
		}

		[Ordinal(2)] 
		[RED("killer")] 
		public wCHandle<entEntity> Killer
		{
			get => GetProperty(ref _killer);
			set => SetProperty(ref _killer, value);
		}

		public OnSquadmateDied(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
