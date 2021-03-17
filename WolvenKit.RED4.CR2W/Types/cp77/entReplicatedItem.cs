using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedItem : CVariable
	{
		private wCHandle<entEntity> _entity;
		private netTime _netTime;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("netTime")] 
		public netTime NetTime
		{
			get => GetProperty(ref _netTime);
			set => SetProperty(ref _netTime, value);
		}

		public entReplicatedItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
